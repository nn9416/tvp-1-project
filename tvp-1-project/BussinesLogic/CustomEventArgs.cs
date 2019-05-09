using System;

namespace tvp_1_project.BussinesLogic
{
    public class CustomEventArgs : EventArgs
    {
        public object Data { get; set; }

        public CustomEventArgs(object data)
        {
            Data = data;
        }
    }
}
