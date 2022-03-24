using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lv2_objektno
{
    class Linija:GrafObj
    {
        #region Properties
        public Point mCurrentCoordinate;
        #endregion

        #region Constructors
        public Linija() { }
        public Linija(Color Color, Point StartCoordinate, Point EndCoordinate) : base(Color, EndCoordinate)
        {
            this.mCurrentCoordinate = EndCoordinate;
        }
        public Linija(GrafObj GrafObjHelper, Point EndCoordinate): base(GrafObjHelper)
        {
            this.mCurrentCoordinate = EndCoordinate;
        }
        #endregion

        #region Methods
       
        public override void DrawGrafObj(Graphics GraphicsHelper)
        {
            GraphicsHelper.DrawLine(new Pen(this.GetColor()), this.GetCoordinate(), mCurrentCoordinate);
        }
        #endregion
    }
}
