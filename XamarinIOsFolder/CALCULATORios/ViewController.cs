using System;

using UIKit;

namespace CALCULATORios
{

    public partial class ViewController : UIViewController
    {

        double firstNum;
        double secondNum;
        String holder = "";
        double result;
        bool button1clicked = false;
        bool button2clicked = false;
        bool button3clicked = false;
        bool button4clicked = false;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            #region Buttons 1-9:
            btn1.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn1.TitleLabel.Text;
            };
            btn2.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn2.TitleLabel.Text;
            };
            btn3.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn3.TitleLabel.Text;
            };
            btn4.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn4.TitleLabel.Text;
            };
            btn5.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn5.TitleLabel.Text;
            };
            btn6.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn6.TitleLabel.Text;
            };
            btn7.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn7.TitleLabel.Text;
            };
            btn8.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn8.TitleLabel.Text;
            };
            btn9.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn9.TitleLabel.Text;
            };
            btn0.TouchUpInside += (sender, e) =>
            {
                textField.Text = textField.Text + btn0.TitleLabel.Text;
            };
            #endregion

            #region Operation Buttons:

            btnAdd.TouchUpInside += (sender, e) =>
            {
                firstNum = Convert.ToDouble(textField.Text);
                textField.Text = holder;
                button1clicked = true;
            };
            btnSub.TouchUpInside += (sender, e) =>
            {
                firstNum = Convert.ToDouble(textField.Text);
                textField.Text = holder;
                button2clicked = true;
            };

            btnMul.TouchUpInside += (sender, e) =>
            {
                firstNum = Convert.ToDouble(textField.Text);
                textField.Text = holder;
                button3clicked = true;
            };

            btnDiv.TouchUpInside += (sender, e) =>
            {
                firstNum = Convert.ToDouble(textField.Text);
                textField.Text = holder;
                button4clicked = true;

            };

            btnEql.TouchUpInside += (sender, e) =>
            {
                if (button1clicked == true)
                {
                    Calculate(1);
                }
                if (button2clicked == true)
                {
                    Calculate(2);
                }
                if (button3clicked == true)
                {
                    Calculate(3);
                }
                if (button4clicked == true)
                {
                    Calculate(4);
                }

            };

            btnDel.TouchUpInside += (sender, e) =>
            {
                textField.Text = holder;
                firstNum = 0;

            };
        }

        #endregion

        #region Calculator Logic:

        public void Calculate(int opType){
           
            switch (opType)
            {
                case 1:
                    secondNum = Convert.ToDouble(textField.Text);
                    result = firstNum + secondNum;
                    textField.Text = result.ToString();
                    button1clicked = false;
                    break;
                case 2:
                    secondNum = Convert.ToDouble(textField.Text);
                    result = firstNum - secondNum;
                    textField.Text = result.ToString();
                    button2clicked = false;
                    break;
                case 3:
                    secondNum = Convert.ToDouble(textField.Text);
                    result = firstNum * secondNum;
                    textField.Text = result.ToString();
                    button3clicked = false;
                    break;
                case 4:
                    secondNum = Convert.ToDouble(textField.Text);
                    result = firstNum / secondNum;
                    textField.Text = result.ToString();

                    if(secondNum == 0){

                        var okAlertController = UIAlertController.Create("ERROR", "Cannot divide by Zero.", UIAlertControllerStyle.Alert);

                        //Add Action
                        okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                        // Present Alert
                        PresentViewController(okAlertController, true, null);

                        textField.Text = "ERROR";

                    }

                    button4clicked = false;
                    break;
            }
        }
        #endregion

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
