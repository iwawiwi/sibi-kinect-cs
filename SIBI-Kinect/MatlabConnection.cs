﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace SIBI_Kinect
{
    public static class MatlabConnection
    {

        public static void testOutput()
        {
            MLApp.MLAppClass matlab = new MLApp.MLAppClass();

            int a = 2;
            int b = 6;

            matlab.PutWorkspaceData("a", "base", a);
            matlab.PutWorkspaceData("b", "base", b);
            matlab.Execute("cd 'D:\\Dropbox\\Research Assistant\\SIBI Data Feature\\Code\\kencoba'");
            matlab.Execute("c = a + b");
            matlab.Execute("com.mathworks.mlservices.MLEditorServices.closeAll");;

        }

        public static void seeGraph(string folderName, int args)
        {
            MLApp.MLAppClass matlab = new MLApp.MLAppClass();

            matlab.PutWorkspaceData("Graphargs", "base", args);
            matlab.PutWorkspaceData("folderName", "base", folderName);

            matlab.Execute("cd 'D:\\Dropbox\\Research Assistant\\SIBI Data Feature\\Code\\kencoba\\'");
            matlab.Execute("FeatureLooker(folderName,Graphargs);");
            //matlab.Execute("com.mathworks.mlservices.MLEditorServices.closeAll");
        }
    }
}
