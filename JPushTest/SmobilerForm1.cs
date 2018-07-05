using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using Smobiler.Utility.JPush;

namespace JPushTest
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        /// <summary>
        /// 极光Key
        /// </summary>
        private static string appKey = "用户填写";
        private static string appSecret = "用户填写";
        PushClient jPushClient = new PushClient(appKey, appSecret);

        private void button1_Press(object sender, EventArgs e)
        {
            this.Client.Push.SetAlias(this.textBox1.Text, (obj, args) =>
            {
                if (args.isError == true)
                    this.Toast(args.error);
                else
                    this.Toast("Success");
            });
        }

        private void button2_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.Push(textBox2.Text, textBox1.Text);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button3_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushAll(textBox2.Text, PushPlatform.android);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button4_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushAlert(textBox2.Text, textBox1.Text, textBox1.Text);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button5_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushAlertAll(textBox2.Text, textBox1.Text, PushPlatform.android);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button6_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushURL(textBox2.Text, "https://www.baidu.com/", textBox1.Text);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button7_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushURLAll(textBox2.Text, "https://www.baidu.com/", PushPlatform.android);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button8_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushClientCallBack(textBox2.Text, textBox2.Text, textBox1.Text);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button9_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushClientCallBackAll(textBox2.Text, textBox2.Text, PushPlatform.android);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button10_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushBigText(textBox2.Text, textBox2.Text, textBox1.Text, textBox1.Text);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }

        private void button11_Press(object sender, EventArgs e)
        {
            try
            {
                jPushClient.PushBigTextAll(textBox2.Text, textBox2.Text, textBox1.Text, PushPlatform.all);
            }
            catch (cn.jpush.api.common.APIRequestException apiex)
            {
                MessageBox.Show(string.Format("{0}/{1}", apiex.Message, apiex.ErrorMessage));
            }
        }
    }
}