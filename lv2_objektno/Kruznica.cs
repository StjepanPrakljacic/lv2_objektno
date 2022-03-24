using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class Kruznica: GrafObj
    {
        #region Properties
        private float mRadius;
        public Point mCurrentCoordinate;
        #endregion

        #region Constructors
        public Kruznica() { }
        public Kruznica(Color Color, Point StartCoordinate, Point EndCoordinate): base(Color, StartCoordinate)
        {
            this.mCurrentCoordinate = EndCoordinate;
            this.mRadius = (float)Math.Sqrt(Math.Pow(mCurrentCoordinate.X - this.GetCoordinate().X, 2) + Math.Pow(mCurrentCoordinate.Y - this.GetCoordinate().Y,2));
        }
        public Kruznica(GrafObj GrafObjHelper, Point EndCoordinate): base(GrafObjHelper)
        {
            this.mCurrentCoordinate = EndCoordinate;
            this.mRadius = (float)Math.Sqrt(Math.Pow(mCurrentCoordinate.X - this.GetCoordinate().X, 2) + Math.Pow(mCurrentCoordinate.Y - this.GetCoordinate().Y, 2));
        }

        #endregion

        #region Methods
       public void SetRadius(float Value)
        {
            this.mRadius = Value;
        }
        public float GetRadius()
        {
            return this.mRadius;
        }
        public override void DrawGrafObj(Graphics GraphicsHelper)
        {
            GraphicsHelper.DrawEllipse(new Pen(this.GetColor()),Math.Min(this.GetCoordinate().X, mCurrentCoordinate.X), Math.Min(this.GetCoordinate().Y, mCurrentCoordinate.Y), mRadius, mRadius);
        }
        #endregion
    }
}
