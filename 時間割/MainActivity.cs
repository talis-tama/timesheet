using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading.Tasks;

namespace timesheet
{
    [Activity(Label = "時間割", MainLauncher = true, Icon = "@drawable/icon", ScreenOrientation =Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        TextView show1, show2, show3, show4, show5, show6, show7, show8, show9, show10, show11, show12, show13, show14, show15,label2, label3, label4, label5, label6, label7;
        Task timer;
        Button button1, button3;
        int hour, minute, week, cls, selecter;
        bool swt, chk = true;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            initalizing();
            time();
            process();
            read();
            timer = new Task(async () =>
            {
                while (true)
                {
                    RunOnUiThread(() =>
                    {
                        time();
                        if (swt == true)
                        {
                            process();
                            read();
                        }
                    });
                    await Task.Delay(1000);
                }
            });
            timer.Start();
        }
        void initalizing()
        {
            show1 = (TextView)FindViewById(Resource.Id.show1);
            show2 = (TextView)FindViewById(Resource.Id.show2);
            show3 = (TextView)FindViewById(Resource.Id.show3);
            show4 = (TextView)FindViewById(Resource.Id.show4);
            show5 = (TextView)FindViewById(Resource.Id.show5);
            show6 = (TextView)FindViewById(Resource.Id.show6);
            show7 = (TextView)FindViewById(Resource.Id.show7);
            show8 = (TextView)FindViewById(Resource.Id.show8);
            show9 = (TextView)FindViewById(Resource.Id.show9);
            show10 = (TextView)FindViewById(Resource.Id.show10);
            show11 = (TextView)FindViewById(Resource.Id.show11);
            show12 = (TextView)FindViewById(Resource.Id.show12);
            show13 = (TextView)FindViewById(Resource.Id.show13);
            show14 = (TextView)FindViewById(Resource.Id.show14);
            show15 = (TextView)FindViewById(Resource.Id.show15);
            label2 = (TextView)FindViewById(Resource.Id.label2);
            label3 = (TextView)FindViewById(Resource.Id.label3);
            label4 = (TextView)FindViewById(Resource.Id.label4);
            label5 = (TextView)FindViewById(Resource.Id.label5);
            label6 = (TextView)FindViewById(Resource.Id.label6);
            label7 = (TextView)FindViewById(Resource.Id.label7);
            button1 = (Button)FindViewById(Resource.Id.button1);
            button3 = (Button)FindViewById(Resource.Id.button3);
            button1.Click += button1_click;
            button3.Click += button3_click;
            DateTime time = new DateTime();
            time = DateTime.Now;
            selecter = (int)time.DayOfWeek;
            if (selecter == 0) { selecter = 1; }
        }
        void time()
        {
            DateTime tim = new DateTime();
            tim = DateTime.Now;
            show1.Text = tim.ToString("M月d日(ddd)H時m分");
            hour = tim.Hour;
            minute = tim.Minute;
            week = (int)tim.DayOfWeek;
        }
        void process()
        {
            if (hour >= 0 && hour <= 8 || hour == 9 && minute >= 0 && minute <= 19) { cls = 1; }
            else if (hour == 9 && minute >= 20 || hour == 10) { cls = 2; }
            else if (hour == 11 || hour == 12 || hour == 13 && minute <= 19) { cls = 3; }
            else if (hour == 13 && minute >= 20 || hour == 14) { cls = 4; }
            else if (hour == 15 || hour == 16 && minute <= 39) { cls = 5; }
            else if (hour == 16 && minute >= 40 || hour >= 17 && hour <= 23) { cls = 0; }
        }
        void read()
        {
            if (week == 0)//日曜日
            {
                sun();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if(cls==2)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if(cls==3)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 4)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 1)//月曜日
            {
                mon();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "健康・スポーツ実習II";
                    show3.Text = "13:20～14:50";
                    show4.Text = "井上 望";
                    show5.Text = "----";
                }
                else if (cls == 2)
                {
                    show2.Text = "健康・スポーツ実習II";
                    show3.Text = "13:20～14:50";
                    show4.Text = "井上 望";
                    show5.Text = "----";
                }
                else if (cls == 3)
                {
                    show2.Text = "健康・スポーツ実習II";
                    show3.Text = "13:20～14:50";
                    show4.Text = "井上 望";
                    show5.Text = "----";
                }
                else if (cls == 4)
                {
                    show2.Text = "中国語IB";
                    show3.Text = "15:00～16:30";
                    show4.Text = "河合 史恵";
                    show5.Text = "7403";
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 2)//火曜日
            {
                tue();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "英語IB";
                    show3.Text = "11:00～12:30";
                    show4.Text = "石川 真知子";
                    show5.Text = "7402";
                }
                else if (cls == 2)
                {
                    show2.Text = "英語IB";
                    show3.Text = "11:00～12:30";
                    show4.Text = "石川 真知子";
                    show5.Text = "7402";
                }
                else if (cls == 3)
                {
                    show2.Text = "英語演習II";
                    show3.Text = "13:20～14:50";
                    show4.Text = "T.Rucynski";
                    show5.Text = "3407";
                }
                else if (cls == 4)
                {
                    show2.Text = "キャリア基礎II";
                    show3.Text = "15:00～16:30";
                    show4.Text = "小山 知子";
                    show5.Text = "3405";
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 3)//水曜日
            {
                wed();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "英語IIB";
                    show3.Text = "11:00～12:30";
                    show4.Text = "T.Rucynski";
                    show5.Text = "3407";
                }
                else if (cls == 2)
                {
                    show2.Text = "英語IIB";
                    show3.Text = "11:00～12:30";
                    show4.Text = "T.Rucynski";
                    show5.Text = "3407";
                }
                else if (cls == 3)
                {
                    show2.Text = "中国語IIB";
                    show3.Text = "13:20～14:50";
                    show4.Text = "蒋 彧亭";
                    show5.Text = "3302";
                }
                else if (cls == 4)
                {
                    show2.Text = "情報記録概論";
                    show3.Text = "15:00～16:30";
                    show4.Text = "村越 一哲";
                    show5.Text = "7313";
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 4)//木曜日
            {
                thr();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "プレゼミナールII";
                    show3.Text = "9:20～10:50";
                    show4.Text = "今村 庸一";
                    show5.Text = "2107";
                }
                else if (cls == 2)
                {
                    show2.Text = "経済学II";
                    show3.Text = "11:00～12:30";
                    show4.Text = "佐川 和彦";
                    show5.Text = "7002";
                }
                else if (cls == 3)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 4)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 5)//金曜日
            {
                fri();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "プログラミング入門演習";
                    show3.Text = "9:20～10:50";
                    show4.Text = "寺嶋 秀美";
                    show5.Text = "7501";
                }
                else if (cls == 2)
                {
                    show2.Text = "中国語と文化";
                    show3.Text = "11:00～12:30";
                    show4.Text = "葉 紅";
                    show5.Text = "3406";
                }
                else if (cls == 3)
                {
                    show2.Text = "コンピュータ・リテラシーII";
                    show3.Text = "13:20～14:50";
                    show4.Text = "太田 康友";
                    show5.Text = "3504";
                }
                else if (cls == 4)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
            else if (week == 6)//土曜日
            {
                sat();
                if (cls == 0)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 1)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 2)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 3)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 4)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
                else if (cls == 5)
                {
                    show2.Text = "無し";
                    show3.Text = "----";
                    show4.Text = "----";
                    show5.Text = "----";
                    readmore();
                }
            }
        }
        void readmore()
        {
            if (chk == true)
            {
                chk = false;
                if (selecter == 6) { selecter = 1; }
                else { selecter = selecter + 1; }
            }
            label2.Text = "";
            label3.Text = "本日の予定";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            show2.Text = "本日の授業はすべて終了しました";
            show3.Text = "";
            show4.Text = "";
            show5.Text = "";
            if (week == 0 || week == 6)
            {
                label7.Text = "月曜日の予定";
                mon();
            }
            else if (week == 1)
            {
                label7.Text = "火曜日の予定";
                tue();
            }
            else if (week == 2)
            {
                label7.Text = "水曜日の予定";
                wed();
            }
            else if (week == 3)
            {
                label7.Text = "木曜日の予定";
                thr();
            }
            else if (week == 4)
            {
                label7.Text = "金曜日の予定";
                fri();
            }
            else if (week == 5)
            {
                label7.Text = "土曜日の予定";
                sat();
            }
            if (week == 0) { show2.Text = "本日は休日です"; }
        }
        void sun()
        {
            show6.Text = "空き";
            show7.Text = "----";
            show8.Text = "空き";
            show9.Text = "----";
            show10.Text = "空き";
            show11.Text = "----";
            show12.Text = "空き";
            show13.Text = "----";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void mon()
        {
            show6.Text = "空き";
            show7.Text = "----";
            show8.Text = "空き";
            show9.Text = "----";
            show10.Text = "健康・スポーツ実習II";
            show11.Text = "----";
            show12.Text = "中国語IB";
            show13.Text = "7403";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void tue()
        {
            show6.Text = "空き";
            show7.Text = "----";
            show8.Text = "英語IB";
            show9.Text = "7402";
            show10.Text = "英語演習II";
            show11.Text = "3407";
            show12.Text = "キャリア基礎II";
            show13.Text = "3405";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void wed()
        {
            show6.Text = "空き";
            show7.Text = "----";
            show8.Text = "英語IIB";
            show9.Text = "3407";
            show10.Text = "中国語IIB";
            show11.Text = "3302";
            show12.Text = "記録情報概論";
            show13.Text = "7313";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void thr()
        {
            show6.Text = "プレゼミナールII";
            show7.Text = "2107";
            show8.Text = "経済学II";
            show9.Text = "7002";
            show10.Text = "空き";
            show11.Text = "----";
            show12.Text = "空き";
            show13.Text = "----";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void fri()
        {
            show6.Text = "プログラミング入門演習";
            show7.Text = "7501";
            show8.Text = "中国語と文化";
            show9.Text = "3406";
            show10.Text = "コンピュータ・リテラシーII";
            show11.Text = "3504";
            show12.Text = "空き";
            show13.Text = "----";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void sat()
        {
            show6.Text = "空き";
            show7.Text = "----";
            show8.Text = "空き";
            show9.Text = "----";
            show10.Text = "空き";
            show11.Text = "----";
            show12.Text = "空き";
            show13.Text = "----";
            show14.Text = "空き";
            show15.Text = "----";
        }
        void button1_click(object sender,EventArgs e)
        {
            swt = false;
            if (selecter == 1) { selecter = 6; }
            else { selecter = selecter - 1; }
            select();
        }
        void button3_click(object sender,EventArgs e)
        {
            swt = false;
            if (selecter == 6) { selecter = 1; }
            else { selecter = selecter + 1; }
            select();
        }
        void select()
        {
            if (selecter == 1)
            {
                label7.Text = "月曜日の予定";
                mon();
            }
            else if (selecter == 2)
            {
                label7.Text = "火曜日の予定";
                tue();
            }
            else if (selecter == 3)
            {
                label7.Text = "水曜日の予定";
                wed();
            }
            else if (selecter == 4)
            {
                label7.Text = "木曜日の予定";
                thr();
            }
            else if (selecter == 5)
            {
                label7.Text = "金曜日の予定";
                fri();
            }
            else if (selecter == 6)
            {
                label7.Text = "土曜日の予定";
                sat();
            }
        }
    }
}

