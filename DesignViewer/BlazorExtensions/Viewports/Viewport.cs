using Model.Design.Math;
using Model.Utils;

namespace BlazorExtensions.Viewports
{
    public class Viewport : IViewport
    {
        private float _scrollX;
        private float _scrollY;
        private float _zoom = 1f;

        public Viewport(
            Size size, 
            Size contentSize, 
            Sides contentScrollMargin, 
            float scrollbarSize = 16f)
        {
            Size = size;
            ContentSize = contentSize;
            ContentScrollMargin = contentScrollMargin;
            ScrollbarSize = scrollbarSize;
        }

        public event EventHandler<ZoomChangedEventArgs> ZoomChanged;
        public event EventHandler<ScrollChangedEventArgs> ScrollChanged;

        public Size Size { get; set; }

        public Size ContentSize { get; set; }

        public Sides ContentScrollMargin { get; set; }

        public float ScrollbarSize { get; set; }

        public bool IsHorizontalScrollbarShown
        {
            get
            {
                return ScrollableAreaSize.Height > Size.Width;
            }
        }

        public bool IsVerticalScrollbarShown
        {
            get
            {
                return ScrollableAreaSize.Height > Size.Height;
            }
        }

        public Size ScrollableAreaSize 
        { 
            get
            {
                return new Size()
                {
                    Width = ContentSize.Width * Zoom
                    + ContentScrollMargin.Right
                    + ContentScrollMargin.Left,

                    Height = ContentSize.Height * Zoom
                    + ContentScrollMargin.Top
                    + ContentScrollMargin.Bottom
                };
            }
        }

        public float VerticalScrollbarBodyPos
        {
            get
            {
                float topLimitY = (Size.Height - ContentSize.Height * Zoom) 
                    / 2f + ScrollY - ContentScrollMargin.Top;

                return -topLimitY * (Size.Height - ScrollbarSize) 
                    / ScrollableAreaSize.Height;
            }
        }

        public float HorizontalScrollbarBodyPos
        {
            get
            {
                float leftLimitX = (Size.Width - ContentSize.Width * Zoom) 
                    / 2f + ScrollX - ContentScrollMargin.Left;

                return -leftLimitX * (Size.Width - ScrollbarSize) 
                    / ScrollableAreaSize.Width;
            }
        }

        public float VerticalScrollbarBodyHeight
        {
            get
            {
                return Size.Height * (Size.Height - ScrollbarSize) 
                    / ScrollableAreaSize.Height;
            }
        }

        public float HorizontalScrollbarBodyWidth
        {
            get
            {
                return Size.Width * (Size.Width - ScrollbarSize) 
                    / ScrollableAreaSize.Width;
            }
        }

        public float VerticalScrollbarHeight
        {
            get
            {
                return Size.Height - ScrollbarSize;
            }
        }

        public float HorizontalScrollbarWidth
        {
            get
            {
                return Size.Width - ScrollbarSize;
            }
        }

        public float ScrollX
        {
            get
            {
                // Saves from incorrect scrollbar behaviour when zoom is changing
                if (_scrollX < MinScrollX)
                {
                    _scrollX = MinScrollX;
                }
                if (_scrollX > MaxScrollX)
                {
                    _scrollX = MaxScrollX;
                }

                return _scrollX;
            }
            set
            {
                float previous = ScrollX;

                if (value < MinScrollX)
                {
                    _scrollX = MinScrollX;
                    return;
                }
                if (value > MaxScrollX)
                {
                    _scrollX = MaxScrollX;
                    return;
                }

                _scrollX = value;

                ScrollChanged?.Invoke(
                    this,
                    new ScrollChangedEventArgs(_scrollX, ScrollY, _scrollX - previous, 0));
            }
        }
        
        public float ScrollY
        {
            get
            {
                // Saves from incorrect scrollbar behaviour when zoom is changing
                if (_scrollY < MinScrollY)
                {
                    _scrollY = MinScrollY;
                }
                if (_scrollY > MaxScrollY)
                {
                    _scrollY = MaxScrollY;
                }

                return _scrollY;
            }
            set
            {
                float previous = ScrollY;

                if (value < MinScrollY)
                {
                    _scrollY = MinScrollY;
                    return;
                }
                if (value > MaxScrollY)
                {
                    _scrollY = MaxScrollY;
                    return;
                }

                _scrollY = value;

                ScrollChanged?.Invoke(
                    this,
                    new ScrollChangedEventArgs(ScrollX, _scrollY, 0, _scrollY - previous));
            }
        }

        public float Zoom
        {
            get
            {
                return _zoom;
            }
            set
            {
                float previous = _zoom;

                _zoom = MathUtils.Clamp(value, MinZoom, MaxZoom);

                ZoomChanged?.Invoke(this, new ZoomChangedEventArgs(_zoom, _zoom / previous));
            }
        }

        public float MinZoom { get; set; } = 0.2f;

        public float MaxZoom { get; set; } = 5f;

        private float MinScrollX
        {
            get
            {
                return (Size.Width - (ContentSize.Width * Zoom)) / 2f 
                    - ContentScrollMargin.Right;
            }
        }

        private float MaxScrollX
        {
            get
            {
                return ContentScrollMargin.Left 
                    - (Size.Width - (ContentSize.Width * Zoom)) / 2f;
            }
        }

        private float MinScrollY
        {
            get
            {
                return (Size.Height - (ContentSize.Height * Zoom)) / 2f 
                    - ContentScrollMargin.Bottom;
            }
        }

        private float MaxScrollY
        {
            get
            {
                return ContentScrollMargin.Top 
                    - (Size.Height - (ContentSize.Height * Zoom)) / 2f;
            }
        }
    }
}
