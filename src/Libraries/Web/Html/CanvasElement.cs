// CanvasElement.cs
// Script#/Libraries/Web
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;
using System.Html.Media.Graphics;
using System.Interop.OpenGL;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class CanvasElement : Element {

        private CanvasElement() {
        }

        [IntrinsicProperty]
        public int Height {
            get {
                return 0;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public int Width {
            get {
                return 0;
            }
            set {
            }
        }

        public CanvasContext GetContext(string contextID) {
            return null;
        }

        public object GetContext(string contextID, params object[] args) { return null; }

        public CanvasContext GetContext(Rendering renderingType) {
            return null;
        }

        public CanvasContext2D GetContext2D() { return (CanvasContext2D)GetContext("2d"); }

        [AlternateSignature]
        public extern WebGLRenderingContext GetContextWebGL();
        public WebGLRenderingContext GetContextWebGL(WebGLContextAttributes attributes)
        {
            if (attributes == null)
                attributes = new WebGLContextAttributes();
            string[] names = { "experimental-webgl", "webgl", "moz-webgl", "webkit-webgl", "webkit-3d" };
            for (int index = 0; index < names.Length; index++)
            {
                try
                {
                    WebGLRenderingContext ctx = (WebGLRenderingContext)GetContext(names[index], attributes);
                    // Hook for the semi-standard WebGLDebugUtils script.
                    if ((bool)Script.Literal("window.WebGLDebugUtils"))
                        return (WebGLRenderingContext)Script.Literal("window.WebGLDebugUtils.makeDebugContext({0})", ctx);
                    return ctx;
                }
                catch { }
            }
            return null;
        }

        [ScriptName("toDataURL")]
        public string GetDataUrl() {
            return null;
        }

        [ScriptName("toDataURL")]
        public string GetDataUrl(string type) {
            return null;
        }

        [ScriptName("toDataURL")]
        public string GetDataUrl(string type, params object[] typeArguments) {
            return null;
        }
    }
}
