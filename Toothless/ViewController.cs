using Foundation;
using System;
using UIKit;
using CoreBluetooth;

namespace Toothless
{
    public partial class ViewController : UIViewController, ICBPeripheralManagerDelegate
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var myPeripheralManager = new CBPeripheralManager(this, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void StateUpdated(CBPeripheralManager peripheral)
        {
            
        }
    }
}