﻿using System;
using System.Xml;
using SvgToVectorDrawableConverter.DataFormat.Common;

namespace SvgToVectorDrawableConverter.DataFormat.VectorDrawable
{
    class Path : Element
    {
        public Path(XmlElement wrappedElement)
        : base(wrappedElement)
        { }

        public string PathData
        {
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        public string FillColor
        {
            get { return GetAttribute<string>(); }
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        public string StrokeColor
        {
            get { return GetAttribute<string>(); }
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        public float StrokeWidth
        {
            get { return GetAttribute<float>(); }
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        public float StrokeAlpha
        {
            get { return GetAttribute(1f); }
            set
            {
                SetAttribute(value, "android", 1);
                SetAttribute(value, "auto", 1);
            }
        }

        public float FillAlpha
        {
            get { return GetAttribute(1f); }
            set
            {
                SetAttribute(value, "android", 1);
                SetAttribute(value, "auto", 1);
            }
        }

        public double TrimPathStart
        {
            set
            {
                SetAttribute(Convert.ToSingle(value), "android");
                SetAttribute(Convert.ToSingle(value), "auto");
            }
        }

        public double TrimPathEnd
        {
            set
            {
                SetAttribute(Convert.ToSingle(value), "android");
                SetAttribute(Convert.ToSingle(value), "auto");
            }
        }

        public double TrimPathOffset
        {
            set
            {
                SetAttribute(Convert.ToSingle(value), "android");
                SetAttribute(Convert.ToSingle(value), "auto");
            }
        }

        /// <summary>
        /// Sets the linecap for a stroked path: butt, round, square.
        /// </summary>
        public string StrokeLineCap
        {
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        /// <summary>
        /// Sets the lineJoin for a stroked path: miter, round, bevel.
        /// </summary>
        public string StrokeLineJoin
        {
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }

        public string StrokeMiterLimit
        {
            set
            {
                SetAttribute(value, "android");
                SetAttribute(value, "auto");
            }
        }
    }
}