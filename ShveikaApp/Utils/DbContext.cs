using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShveikaApp.Model;

namespace ShveikaApp.Utils
{
    internal class DbContext
    {
        private static GlazkiModel _model { get; set; }
        public static GlazkiModel Model
        {
            get => _model ?? (_model = new GlazkiModel());
        }   

    }
}
