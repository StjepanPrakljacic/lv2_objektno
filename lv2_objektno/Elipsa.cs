using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class Elipsa : Kruznica
    {
        #region Properties
        public float mHeight;
        #endregion

        #region Constructors
        public Elipsa() { }
        public Elipsa(Color Color, Point StartCoordinate, Point EndCoordinate) : base(Color, StartCoordinate, EndCoordinate)
        {
            this.mHeight = Math.Abs(this.GetCoordinate().Y - mCurrentCoordinate.Y);
        }
        public Elipsa(GrafObj GrafObjHelper, Point EndCoordinate) : base(GrafObjHelper, EndCoordinate)
        {
            this.mHeight = Math.Abs(this.GetCoordinate().Y - mCurrentCoordinate.Y);
        }
        #endregion

        #region Methods
        public void SetHeight(float Value)
        {
            this.mHeight = Value;
        }
        public override void DrawGrafObj(Graphics GraphicsHelper)
        {
            GraphicsHelper.DrawEllipse(new Pen(this.GetColor()), Math.Min(this.GetCoordinate().X, mCurrentCoordinate.X), Math.Min(this.GetCoordinate().Y, mCurrentCoordinate.Y), this.GetRadius(), mHeight);
        }
        #endregion
    }
}
