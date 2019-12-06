using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;


namespace ThingamajigActivities
{
    public class WiggleGirtHoppinator : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InArgument<double> WiggleBandWidth { get; set; }

        [Category("Input")]
        public InArgument<double> HoppyGirtleLength { get; set; }

        [Category("Output")]
        public OutArgument<double> ThingyDingy { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = WiggleBandWidth.Get(context);
            var secondNumber = HoppyGirtleLength.Get(context);
            var result = System.Math.Min(firstNumber, secondNumber);
            ThingyDingy.Set(context, result);
        }
    }
}
