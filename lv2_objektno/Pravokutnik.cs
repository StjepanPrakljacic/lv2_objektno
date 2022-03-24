using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class Pravokutnik:Linija
    {
        #region Constructors
        public Pravokutnik() { }
        public Pravokutnik(Color Color, Point StartCoordinate, Point EndCoordinate) : base( Color,  StartCoordinate,  EndCoordinate) { }
        public Pravokutnik(GrafObj GrafObjHelper, Point EndCoordinate) : base(GrafObjHelper, EndCoordinate) { }
        #endregion

        #region Methods
        public override void DrawGrafObj(Graphics GraphicsHelper)
        {
            GraphicsHelper.DrawRectangle(new Pen(this.GetColor()), this.GetCoordinate().X, this.GetCoordinate().Y, this.mCurrentCoordinate.X - this.GetCoordinate().X, this.mCurrentCoordinate.Y - this.GetCoordinate().Y);
        }
        #endregion
    }
}
