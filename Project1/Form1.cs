using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        //RDT:Read Text이벤트
        public delegate string[] RDtext();
        public event RDtext RDT;
        MainForm mf = null;

        public Form1(MainForm mainform)
        {
            //RDT:Read Text이벤트에 RD()메소드 추가
            InitializeComponent();
            this.RDT += new RDtext(RD);
            mf = mainform;
        }

        private void constructionBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// text 값 읽어오기, html파일저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //text값 읽어서 array에 저장.
            string[] strarray =RDT();

            //Console.WriteLine("{0}", strarray[0]);

            ArrayList convertedArray1 = this.Convert2html(strarray[0]);
            ArrayList convertedArray2 = this.Convert2html(strarray[1]);
            ArrayList convertedArray3 = this.Convert2html(strarray[2]);
            ArrayList convertedArray4 = this.Convert2html(strarray[3]);
            ArrayList convertedArray5 = this.Convert2html(strarray[4]);
            ArrayList convertedArray6 = this.Convert2html(strarray[5]);
            ArrayList convertedArray7 = this.Convert2html(strarray[6]);

            string fileName = "";

            // SaveFileDialog 객체 생성
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // 기본 저장 경로
            saveFileDialog.InitialDirectory = @"C:\Users\Hyunseong Kim\OneDrive\바탕 화면";
            // saveFileDialog 창 이름 설정
            saveFileDialog.Title = "Html 저장 위치 지정";
            //파일 형식
            saveFileDialog.Filter = "html(*.html)|*.html|모든파일|*.*";
            // 기본 확장자
            saveFileDialog.DefaultExt = "html";

            saveFileDialog.FileName = strarray[0];

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName.ToString();
            }

            if (fileName != "")
            {
                // HTML TABLE 저장.
                MakeHtml(convertedArray1, convertedArray2, convertedArray3,
                    convertedArray4, convertedArray5, convertedArray6, convertedArray7, fileName);

                // MainForm에 file 주소, methodname 정보전달.
                mf.AddNode1(fileName, strarray[0]);
            }
            
        }

       
                
        /// <summary>
        /// textbox의 text 읽는 함수
        /// </summary>
        /// <returns>읽은 text를 string array형태로 반환</returns>
        private string[] RD()
        {
            string methodname = methodNameBox.Text;
            string description = descriptionBox.Text;
            string construction = constructionBox.Text;
            string parameters = parameterBox.Text;
            string revalues = revalBox.Text;
            string exampls = exampleBox.Text;
            string refs = refBox.Text;

            string[] array = new string[] {methodname, description, construction, parameters
            , revalues, exampls, refs};

            return array;
        }


        /// <summary>
        /// text값을 읽어서 특수문자를 html특수문자로 바꾸어 ArrayList형태로 전달.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>sArrayList</returns>
        private ArrayList Convert2html(string text)
        {
            //Convert할 값으로 매칭시킨 Dictionary
            var CVDIC = new Dictionary<char, string>
            {
                {'<', "&#60"},         // 부등호
                {'>', "&#62" },
                {'\\', "&#92"},        //  \
                {'\"', "&#34"},        // "큰따옴표
                {'\'', "&#39"},        // '작은따옴표
                {':',  "&#58"},        // :콜론
                {';',  "&#59"},        // ;세미콜론
                {'\r', "<br>" },       //<br>태그
                {' ', "&nbsp" }
            };

            //text에서 각 줄을 읽어옴.
            string[] lines = text.Split('\n');

            //변환된 line을 담는 동적배열 선언
            ArrayList NewlineList = new ArrayList();

            foreach (string line in lines)
            {
                //Console.WriteLine("*********************************");
                //Console.WriteLine("|{0}|", line);
                //Console.WriteLine("---------------------------------");
               
                // html로 변환될 line (초기 값은 원래 line 값.)
                string Newline = line;

                // 변경할 index를 기억하는 동적배열 Rememberlist 선언.
                ArrayList Rememberlist = new ArrayList();

                // 변경할 index를 동적배열 Rememberlist에 추가.
                for (int index=0; index < line.Length; index++)
                {
                    char token = line[index];
                    if (CVDIC.ContainsKey(token))
                    {
                        //if (token==' ')
                        //    Console.WriteLine("찾았다!!");
                        //Console.WriteLine("key값은 " + token + " value값은" + CVDIC[token]);
                        Rememberlist.Add(index);
                    }
                }

                // Rememberlist 갯수 출력.
                //Console.WriteLine("Rememberlist 갯수 : {0}", Rememberlist.Count);

                // line 변환하기 -> Newline
                // Rememberlist에 변경할 index값이 존재할경우
                if (Rememberlist.Count > 0)
                {
                    Newline = line.Substring(0, (int)Rememberlist[0]);  //Newline 초기화: line의 0~Rememberlist의 첫 번째 값(index)-1까지

                    for (int num = 0; num < Rememberlist.Count; num++)
                    {
                        //Console.WriteLine("해당 index 값은 : {0}", (int)Rememberlist[num]);

                        string appendstr = CVDIC[line[(int)Rememberlist[num]]];  // Newline에 변환하여 추가할 값. 기존 line[num] -> CVDIC[line[num]]
                        Newline += appendstr;        // Newline에 변환한 값 추가.


                        int start = (int)Rememberlist[num] + 1;                 // line에서 slice하여 Newline에 추가할 시작 index값. 

                        int end;                                          
                        if (num != Rememberlist.Count-1)    // lRememberlist에서 다음 index값이 존재하면.
                        {
                            end = (int)Rememberlist[num + 1]; // end는 다음 index값. (slice시 end -1 까지)
                        }
                        else
                            end = line.Length;             // Rememberlist의 다음 값이 없을 경우 
                                                               // end는 line의 마지막 index+1

                        
                        
                        int len = end - start;              // substring에 사용할 길이 값.
                        string addstring = line.Substring(start, end - start);
                        Newline += addstring;                  
                    }
                }
                
                //Console.WriteLine("New line 값: |{0}|", Newline);

                // NewlineLis에 변환된 line 추가.
                NewlineList.Add(Newline);            
            }

            return (NewlineList);
        }


        /// <summary>
        /// Html파일을 만들어 주는 함수.
        /// </summary>
        private void MakeHtml(ArrayList methodName, ArrayList description, ArrayList construction,
            ArrayList parameter, ArrayList example, ArrayList reval, ArrayList reference, string fileName)
        {
            
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);          
            StreamWriter sw = new StreamWriter(fileStream);

            sw.WriteLine("<!DOCTYPE HTML PUBLIC ' -//W3C//DTD HTML 4.01 Transitional//EN'>");
            sw.WriteLine("<html>");

            sw.WriteLine("<head>");
            sw.WriteLine("<meta charset='utf-8'>");
            sw.WriteLine("</head>");

            sw.WriteLine("<body>");
            sw.WriteLine("<TABLE class=MsoTableGrid style='BORDER-TOP: medium none; BORDER-RIGHT: medium none; BORDER-COLLAPSE: collapse; BORDER-BOTTOM: medium none; BORDER-LEFT: medium none; MARGIN: auto 4.85pt; mso-border-alt: solid windowtext .5pt; mso-yfti-tbllook: 1184; mso-padding-alt: 0cm 5.4pt 0cm 5.4pt; mso-table-lspace: 7.1pt; mso-table-rspace: 7.1pt; mso-table-anchor-vertical: paragraph; mso-table-anchor-horizontal: margin; mso-table-left: left; mso-table-top: .65pt' cellSpacing = 0 cellPadding = 0 align = center border = 1 >");
            
            sw.WriteLine("<thead>");
            sw.WriteLine("<tr>");
            sw.WriteLine("<th colspan='2'>");
            //sw = 
            AL2String(methodName, sw);
            sw.WriteLine("</th>");
            sw.WriteLine("</tr>");
            sw.WriteLine("</thead>");

            sw.WriteLine("<tbody>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td colspan='2'>");
            //sw = 
            AL2String(description, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td>구    문</td>");
            sw.WriteLine("<td>");
            //sw = 
            AL2String(construction, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td>매개변수</td>");
            sw.WriteLine("<td>");
            //sw = 
            AL2String(parameter, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td>반 환 값</td>");
            sw.WriteLine("<td>");
            //sw = 
            AL2String(example, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td>예    제</td>");
            sw.WriteLine("<td>");
            
            AL2String(reval, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("<tr>");
            sw.WriteLine("<td>참고항목</td>");
            sw.WriteLine("<td>");
            
            AL2String(reference, sw);
            sw.WriteLine("</td>");
            sw.WriteLine("</tr>");

            sw.WriteLine("</tbody>");
            sw.WriteLine("</TABLE>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");

            sw.Close();
            fileStream.Close();

        }

        /// <summary>
        /// 변환된 문자열들이 있는 ArrayList를 전달받아 Streamwriter로 파일에 작성.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sw"></param>
        /// <returns></returns>
        private void AL2String(ArrayList array, StreamWriter sw)
        {
            for (int i=0; i<array.Count; i++)
            {
                sw.WriteLine("{0}", array[i]);
            }

            
        }
    }
}