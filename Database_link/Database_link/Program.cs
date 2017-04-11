using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_link
{
    static class Program
    {
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

    
        static void Main()
        {

          

       TaskRepository Trep = new TaskRepository ();
            ServiceParametersRepository tspr = new ServiceParametersRepository();
            ServiceTypesRepository stp = new ServiceTypesRepository();
            ValueRepository vrep = new ValueRepository();
            DataTypesRepository dtrep = new DataTypesRepository();
            Task t = new Task();
            ServiceTypes st = new ServiceTypes();
            ServiceParameters sp1 = new ServiceParameters();
            
            ServiceParameters sp2 = new ServiceParameters();
            DataTypes dt = new DataTypes();
            Value v1 = new Value();
            Value v2 = new Value();
            Value v3 = new Value();
            Value v4 = new Value();
            st.service_type = "ftp";
     
            sp1.name = "user_name";
            dt.data_type = "string"; 
            sp1.Obj_Data_Type = dt;
            sp1.List_Obj_ServiceType = new List<ServiceTypes>();
            sp1.List_Obj_ServiceType.Add(st);
      
            
            v1.Obj_param = sp1;
            v1.Data_Value = "pepik";
            v1.List_Obj_Tasks = new List<Task>();
           v1.List_Obj_Tasks.Add(t);

            vrep.Add(v1);
            vrep.Save();

            sp2.name = "user_pass";
            sp2.Obj_Data_Type = dt;
            sp2.List_Obj_ServiceType = new List<ServiceTypes>();
            sp2.List_Obj_ServiceType.Add(stp.GetAll().ToList<ServiceTypes>()[0]);
            v2.Obj_param = sp2;
            v2.Data_Value = "123";
            v2.List_Obj_Tasks = new List<Task>();
            v2.List_Obj_Tasks.Add(t);
              
            vrep.Add(v2);
              vrep.Save();

      
















            Console.ReadLine();
            
            
            
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

        }
    }
}
