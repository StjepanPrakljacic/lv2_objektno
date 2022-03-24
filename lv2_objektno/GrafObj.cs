using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class GrafObj
    {
        #region Properties
        private Color mColor;
        private Point mCoordinate;
        #endregion

        #region Constructors
        public GrafObj() { }
        public GrafObj(Color Color, Point Coordinate)
        {
            this.mColor = Color;
            this.mCoordinate = Coordinate;
        }
        public GrafObj(GrafObj GrafObjHelper)
        {
            this.mColor = GrafObjHelper.mColor;
            this.mCoordinate = GrafObjHelper.mCoordinate;
        }
        #endregion

        #region Methods
        public Color GetColor()
        {
            return this.mColor;
        }
        public void SetColor(Color Color)
        {
            this.mColor = Color;
        }
        public Point GetCoordinate()
        {
            return this.mCoordinate;
        }
        public void SetCoordinate(Point Coordinate)
        {
            this.mCoordinate = Coordinate;
        }
        public virtual void DrawGrafObj(Graphics GraphicsHelper) { }
        #endregion
    }
}
