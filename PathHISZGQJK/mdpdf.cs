using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using readini;
using dbbase;
using System.IO;
using System.Collections;
using HL7;
using LoadDll;


namespace PathHISJK
{
    class mdpdf
    {
        private LoadDllapi dllxx = new LoadDllapi();
        private static string bggs = "";
        private static IniFiles f = new IniFiles(Application.StartupPath + "\\sz.ini");
        public delegate int JPG2PDF(string jpgname, string pdfname);
        public static string szweb = "";
        public static int bgx = 0;
        public static int bgy = 0;

        public void BMPTOJPG(string F_blh, ref string pdfname, string bglx, string bgxh)
        {          
            string bglj = f.ReadString("dybg", "dybglj", "d:\\pathqc").Replace("\0", "");
            dbbase.odbcdb aa = new odbcdb("DSN=pathnet;UID=pathnet;PWD=4s3c2a1p", "", "");
            string sjklj = f.ReadString("sjklj", "sjklj_dq", "").Replace("\0", ""); // "Provider=MSDASQL.1;Persist Security Info=False;Data Source=pathnetsb;UID=username;PWD=password";

            string[] sjkcs = sjklj.Split(';');
            string odbcname = "";
            try
            {
                for (int j = 0; j < sjkcs.Length; j++)
                {
                    if (sjkcs[j].Split('=')[0].ToLower() == "data source")
                    {
                        odbcname = sjkcs[j].Split('=')[1];
                        j = sjkcs.Length + 100;
                    }
                }
            }
            catch
            { }


            if (odbcname != "")
            {
                aa = new odbcdb("DSN=" + odbcname + ";UID=pathnet;PWD=4s3c2a1p", "pathnet", "4s3c2a1p");
            }

            DataTable jcxx = new DataTable();
            try
            {
                jcxx = aa.GetDataTable("select * from T_jcxx where F_blh='" + F_blh + "'", "jcxx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            //生成临时目录
            if (!System.IO.Directory.Exists(@"c:\temp\" + F_blh))
            {

                System.IO.Directory.CreateDirectory(@"c:\temp\" + F_blh);

            }
            else
            {
                try
                {
                    System.IO.Directory.Delete(@"c:\temp\" + F_blh, true);
                    System.IO.Directory.CreateDirectory(@"c:\temp\" + F_blh);
                }
                catch
                {
                }
            }

            //MessageBox.Show("t2");
            DataTable txlb = aa.GetDataTable("select top 10  * from T_tx where F_blh='" + F_blh + "' and F_sfdy='1'", "txlb");
            string txlbs = "";
            string localpath = "";
            if (txlb.Rows.Count > 0)
            {
                downtx(F_blh, jcxx.Rows[0]["F_txml"].ToString().Trim(), aa, ref txlbs, ref localpath);
            }
            else
            {
                localpath = @"c:\temp\" + F_blh;
            }            
            if (localpath == "")
            {
                pdfname = "";
                return;
            }
            string sbmp = "";
            string stxsm = "";
            string sJPGNAME = localpath + "\\" + F_blh.Trim() + ".pdf";
            string shrjyypdfpath = f.ReadString("shrjyypdfgslj", "shrjyypdfgslj", "").Replace("\0", "");
            if (shrjyypdfpath == "")
            {
                shrjyypdfpath = "\\rpt\\";
            }

            string sBGGSName = Application.StartupPath.ToString() + shrjyypdfpath + jcxx.Rows[0]["F_bggs"].ToString().Trim() + "-" + txlb.Rows.Count.ToString() + "图.frf";
            string inibglj = f.ReadString("dybg", "dybglj", "").Replace("\0", "");
            //MessageBox.Show("t4");
            //try
            //{
                log.WriteMyLog(bglj + " " + inibglj + " " + Application.StartupPath);
            //}
            //catch
            //{ }
            //MessageBox.Show("t4.1");
            if (inibglj != "")
            {

                sBGGSName = inibglj + shrjyypdfpath + jcxx.Rows[0]["F_bggs"].ToString().Trim() + "-" + txlb.Rows.Count.ToString() + "图.frf";
            }
            

            //MessageBox.Show("t4.2");
            //MessageBox.Show(localpath);
            for (int i = 0; i < txlb.Rows.Count; i++)
            {
                //MessageBox.Show(txlb.Rows[i]["F_txsm"].ToString().Trim());
                
                stxsm = stxsm + txlb.Rows[i]["F_txsm"].ToString().Trim() + ",";
                //MessageBox.Show("t4.25");
                sbmp = sbmp + localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim() + ",";
                //MessageBox.Show(txlb.Rows[i]["F_txm"].ToString().Trim());
            }
           
            string bcbdsbmp = sbmp;
            string bcbdstxsm = stxsm;
            int szqm = f.ReadInteger("rpt", "szqm", 0);
            //MessageBox.Show("t4.3");
            string bmppath = f.ReadString("mdbmp", "ysbmp", "d:\\pathqc\\rpt\\ysbmp").Replace("\0", "");
            if (bmppath == "")
            {
                bmppath = f.ReadString("view", "szqmlj", "d:\\pathqc\\rpt\\ysbmp\\").Replace("\0", "");
                bmppath = bmppath.Trim('\\');
            }
            if (f.ReadInteger("rpt", "szqm", 0) == 1)
            {
                //MessageBox.Show("t4.4");
              

                string sYSZMZDLB = f.ReadString("all", "yszmlb", "f_shys");

                DataTable yszmRST = aa.GetDataTable("select " + sYSZMZDLB + " from t_jcxx where f_blh='" + F_blh + "'", "yszmb");
                string sYSZMXMLB = "";
                if (yszmRST.Rows.Count > 0)
                {
                    for (int col = 0; col < yszmRST.Columns.Count; col++)
                    {
                        if (yszmRST.Rows[0][col].ToString().Trim() != "")
                        {
                            if (sYSZMXMLB == "")
                            {
                                sYSZMXMLB = yszmRST.Rows[0][col].ToString().Trim();
                            }
                            else
                            {
                                sYSZMXMLB = sYSZMXMLB + "/" + yszmRST.Rows[0][col].ToString().Trim();
                            }
                        }
 
                    }
                   
                    if (sYSZMXMLB != "")
                    {
                        sYSZMXMLB = sYSZMXMLB.Replace(",", "/");
                        string[] R = sYSZMXMLB.Split('/');
                        string xmlb = "";
                        for (int ri = 0; ri < R.Length; ri++)
                        {
                            if (xmlb == "")
                            {
                                xmlb = R[ri].ToString();
                            }
                            else
                            {
                                if (xmlb.IndexOf(R[ri]) > -1)
                                {
                                }
                                else
                                {
                                    xmlb = xmlb + "/" + R[ri];
                                }
                            }
                           
                        }

                        string[] xinR = xmlb.Split('/');
                       // MessageBox.Show("t4.6");
                        for (int xin = 0; xin < xinR.Length; xin++)
                        {
                            stxsm = stxsm + " ,";
                            sbmp = sbmp + bmppath + "\\" + xinR[xin] + ".bmp,";                
 
                        }


 
                        
                    }
                    else
                    {
                        //因为是审核后才上传，所以肯定有审核医生的
                        stxsm = stxsm + " ,";
                        sbmp = sbmp + bmppath + "\\" + jcxx.Rows[0]["F_shys"].ToString().Trim() + ".bmp,";                
                    }

                }
                else
                {
                    //因为是审核后才上传，所以肯定有审核医生的
                    stxsm = stxsm + " ,";
                    sbmp = sbmp + bmppath + "\\" + jcxx.Rows[0]["F_shys"].ToString().Trim() + ".bmp,";                
                }
                //MessageBox.Show("t5");

                
                
                
                
                sBGGSName = Application.StartupPath.ToString() + "\\rpt-szqm\\" + jcxx.Rows[0]["F_bggs"].ToString().Trim() + "-" + txlb.Rows.Count.ToString() + "图.frf";
                if (inibglj != "")
                {
                    sBGGSName = inibglj + "\\rpt-szqm\\" + jcxx.Rows[0]["F_bggs"].ToString().Trim() + "-" + txlb.Rows.Count.ToString() + "图.frf";
                }
            }
            
            //log.WriteMyLog(sBGGSName);

            //报告图片统一用病理号.jpg
           
         
            
            bggs = jcxx.Rows[0]["F_bggs"].ToString().Trim() + "-" + txlb.Rows.Count.ToString() + "图.frf";

           
            string sSQL_DY = "SELECT * FROM T_JCXX,T_TBS_BG WHERE T_JCXX.F_BLH *= T_TBS_BG.F_BLH AND T_JCXX.F_BLH = '" + F_blh + "'";

            string bcbddytx = ".frf";
            if (f.ReadInteger("bcbddytx", "bcbddytx", 0) == 1)
            {
                bcbddytx = "-" + txlb.Rows.Count.ToString() + "图.frf";
            }

            if (bglx == "bd")
            {
                sBGGSName = Application.StartupPath.ToString() + "\\rpt\\冰冻" + bcbddytx;
                if (inibglj != "")
                {
                    sBGGSName = inibglj + "\\rpt\\冰冻" + bcbddytx;
                }
                sSQL_DY = "SELECT * FROM T_JCXX,T_BDBG WHERE T_JCXX.F_BLH = T_BDBG.F_BLH AND T_JCXX.F_BLH ='" + F_blh + "' and F_BD_BGXH='" + bgxh + "'";
                bggs = "冰冻" + bcbddytx;
                //sJPGNAME = localpath + "\\" + F_blh.Trim() + "_bd_" + dtbd.Rows[j]["F_bd_bgxh"].ToString() + ".jpg";
            }
            if (bglx == "bc")
            {
                DataTable bcbg = aa.GetDataTable("select * from T_bcbg where F_blh='" + F_blh + "' and F_bc_bgxh='" + bgxh + "'", "bcbg");

                sBGGSName = Application.StartupPath.ToString() + "\\rpt\\补充" + bcbddytx;
                if (inibglj != "")
                {
                    sBGGSName = inibglj + "\\rpt\\补充" + bcbddytx;
                }
                if (f.ReadInteger("bcbddytx", "bcbddytx", 0) == 1)
                {
                    sbmp = bcbdsbmp;
                    stxsm = bcbdstxsm;
 
                }
                if (f.ReadInteger("rpt", "bcbgszqm", 0) == 1)
                {
                    sBGGSName = Application.StartupPath.ToString() + "\\rpt-szqm\\补充" + bcbddytx;
                    if (inibglj != "")
                    {
                        sBGGSName = inibglj + "\\rpt-szqm\\补充" + bcbddytx;
                    }
                    sbmp =sbmp + bmppath + "\\" + bcbg.Rows[0]["F_bc_shys"].ToString().Trim() + ".bmp,";
                    stxsm = stxsm + " ,";
 
                }
                sSQL_DY = "SELECT * FROM T_JCXX,T_BCBG WHERE T_JCXX.F_BLH = T_BCBG.F_BLH AND T_JCXX.F_BLH ='" + F_blh + "' and F_BC_BGXH='" + bgxh + "'";
                bggs = "补充" + bcbddytx;
                
                //sJPGNAME = localpath + "\\" + F_blh.Trim() + "_bc_" + dtbc.Rows[m]["F_bc_bgxh"].ToString() + ".jpg";
            }

            //sbmp = sbmp.Substring(0, sbmp.Length - 1);
            //stxsm = stxsm.Substring(0, stxsm.Length - 1);

            log.WriteMyLog("strartpdf");
            ZgqClassPub.prreport pr = new ZgqClassPub.prreport();
            pr.printpdf(sSQL_DY, IntPtr.Zero, sbmp, stxsm, sBGGSName, sJPGNAME,"");
           

           // sJPGNAME = localpath + "\\" + F_blh.Trim() + ".bmp";

           // pr.print(sSQL_DY, IntPtr.Zero, sbmp, stxsm, sBGGSName, sJPGNAME);
            pdfname = localpath + "\\" + F_blh.Trim() + ".pdf";
            
        }

        public static void downtx(string ftp_blh, string txml, odbcdb aa, ref string txlbs, ref string localpath)
        {
            //清空c:\temp_sr目录
            if (!System.IO.Directory.Exists(@"c:\temp\" + ftp_blh))
            {

                System.IO.Directory.CreateDirectory(@"c:\temp\" + ftp_blh);

            }
            else
            {
                try
                {
                    System.IO.Directory.Delete(@"c:\temp\" + ftp_blh, true);
                    System.IO.Directory.CreateDirectory(@"c:\temp\" + ftp_blh);
                }
                catch
                {
                }
            }
            localpath = @"c:\temp\" + ftp_blh;

            //下载FTP参数
            string ftpserver = f.ReadString("ftp", "ftpip", "").Replace("\0", "");
            string ftpuser = f.ReadString("ftp", "user", "ftpuser").Replace("\0", "");
            string ftppwd = f.ReadString("ftp", "pwd", "ftp").Replace("\0", "");
            string ftplocal = f.ReadString("ftp", "ftplocal", "c:\\temp").Replace("\0", "");
            string ftpremotepath = f.ReadString("ftp", "ftpremotepath", "pathimages").Replace("\0", "");
            string ftps = f.ReadString("ftp", "ftp", "").Replace("\0", "");
            string txpath = f.ReadString("txpath", "txpath", "").Replace("\0", "");
            FtpWeb fw = new FtpWeb(ftpserver, ftpremotepath, ftpuser, ftppwd);
            //共享目录
            string gxml = f.ReadString("txpath", "txpath", "").Replace("\0", "");
            string gxuid = f.ReadString("txpath", "username", "").Replace("\0", "");
            string gxpwd = f.ReadString("txpath", "password", "").Replace("\0", "");


            DataTable txlb = aa.GetDataTable("select * from T_tx where F_blh='" + ftp_blh + "' and F_sfdy='1'", "txlb");
            string txm = "";

            if (ftps == "1")//FTP下载方式
            {

                for (int i = 0; i < txlb.Rows.Count; i++)
                {

                    txm = txlb.Rows[i]["F_txm"].ToString().Trim();


                    string ftpstatus = "";
                    try
                    {

                        fw.Download(localpath, txml + "/" + txlb.Rows[i]["F_txm"].ToString().Trim(), txlb.Rows[i]["F_txm"].ToString().Trim(), out ftpstatus);
                        if (ftpstatus == "Error")
                        {
                            log.WriteMyLog("FTP下载图像出错！");
                            localpath = "";
                            return;
                        }
                        else
                        {
                            if (f.ReadInteger("TX", "ZOOM", 0) == 1)
                            {
                                int picx = f.ReadInteger("TX", "picx", 320);
                                int picy = f.ReadInteger("TX", "picy", 240);
                                try
                                {
                                   bool ss = prreport.txzoom(localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), picx, picy);
                                   log.WriteMyLog(ss.ToString());
                                }
                                catch(Exception ex)
                                {
                                    log.WriteMyLog("zoom"+ex.Message);
                                }
                                
                            }
                            txlbs = txlbs + "<Image INDEX=" + (char)34 + (i + 1).ToString() + (char)34 + ">" + localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim() + "</Image>";
                        }
                    }
                    catch
                    {
                        log.WriteMyLog("FTP下载图像出错！");
                    }


                }

            }
            else //共享下载方式
            {
                if (txpath == "")
                {
                    log.WriteMyLog("sz.ini txpath图像目录未设置");
                    return;
                }

                for (int i = 0; i < txlb.Rows.Count; i++)
                {

                    txm = txlb.Rows[i]["F_txm"].ToString().Trim();

                    try
                    {
                        try
                        {
                            File.Copy(txpath + txml + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), true);
                            if (f.ReadInteger("TX", "ZOOM", 0) == 1)
                            {
                                int picx = f.ReadInteger("TX", "picx", 320);
                                int picy = f.ReadInteger("TX", "picy", 240);
                                try
                                {
                                    bool ss = prreport.txzoom(localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim(), picx, picy);
                                    log.WriteMyLog(ss.ToString());
                                }
                                catch (Exception ex)
                                {
                                    log.WriteMyLog("zoom" + ex.Message);
                                }

                            }
                            txlbs = txlbs + "<Image INDEX=" + (char)34 + (i + 1).ToString() + (char)34 + ">" + localpath + "\\" + txlb.Rows[i]["F_txm"].ToString().Trim() + "</Image>";
                        }

                        catch
                        { }


                    }
                    catch
                    {
                        log.WriteMyLog("共享目录不存在！");
                        localpath = "";
                        return;
                    }

                }

            }


        }


    }
}
