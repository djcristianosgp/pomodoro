﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro.Model
{
    public class ConfiguracoesViewModel
    {
        public int iTempoTrabalho { get; set; } = 30;
        public int iTempoPausa { get; set; } = 5;
        public bool bMaximizarModoFoco { get; set; } = false;
        public bool bMaximizarModoDescanso { get; set; } = false;
        public bool bNotificarModoFoco { get; set; } = true;
        public bool bNotificarModoDescanso { get; set; } = true;


    }
}
