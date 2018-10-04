using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HowdyProject
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public void CallClickCountChecker(int point)
		{
			if (clickCounterValue.Text == "")
			{
				ChangeTextBtnAndLabel("Keep on livin'", "Riding the storm", "Feeling blue", "Dizzy miss Lizzy!", "0", point);
			}
			else if (clickCounterValue.Text == "1")
			{
				ChangeTextBtnAndLabel("How's it hangin", "Ace", "Primo", "Sublime", "1", point);
			}
			else
			{
				int currentPoint = int.Parse(pointCount.Text);
				pointCount.Text = (currentPoint + point).ToString();

				btnOne.Visible = false;
				btnTwo.Visible = false;
				btnThree.Visible = false;
				tryAgainBtn.Visible = true;

				switch (pointCount.Text)
				{
					case "3":
						lb_taglineText.Text = "You are feeling way too blue";
						break;
					case "4":
						lb_taglineText.Text = "Come on you are better than this";
						break;
					case "5":
						lb_taglineText.Text = "You can't stay down here forever";
						break;
					case "6":
						lb_taglineText.Text = "Wanna grab some food?";
						break;
					case "7":
						lb_taglineText.Text = "Now we talking";
						break;
					case "8":
						lb_taglineText.Text = "Yeehaa, this is great";
						break;
					case "9":
						lb_taglineText.Text = "Wow are you leading the way to heaven";
						break;
				}
			}
		}

		protected void btnOne_Click(object sender, EventArgs e)
		{
			CallClickCountChecker(1);
		}

		protected void btnTwo_Click(object sender, EventArgs e)
		{
			CallClickCountChecker(2);
		}

		protected void btnThree_Click(object sender, EventArgs e)
		{
			CallClickCountChecker(3);
		}

		public void ChangeTextBtnAndLabel(string lb_text, string btnTextOne, string btnTextTwo, string btnTextThree, string counter, int point)
		{
			int currentPoint = int.Parse(pointCount.Text);
			pointCount.Text = (currentPoint + point).ToString();

			int currentCount = int.Parse(counter);
			currentCount++;
			clickCounterValue.Text = currentCount.ToString();

			lb_taglineText.Text = lb_text;
			btnOne.Text = btnTextOne;
			btnTwo.Text = btnTextTwo;
			btnThree.Text = btnTextThree;
		}

		protected void tryAgainBtn_Click(object sender, EventArgs e)
		{
			pointCount.Text = "0";
			clickCounterValue.Text = "";

			lb_taglineText.Text = "Do you feel groovy?";
			btnOne.Text = "Keep on dreamin'";
			btnTwo.Text = "You know it!";
			btnThree.Text = "Off the hook";

			btnOne.Visible = true;
			btnTwo.Visible = true;
			btnThree.Visible = true;
			tryAgainBtn.Visible = false;
		}
	}
}