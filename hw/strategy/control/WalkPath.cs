﻿using System;
namespace control
{
    public class WalkPath : StrategyPath
    {
        public WalkPath()
        {
            Type = "Walk directions";
        }

        public override string ToString()
        {
            return Type;
        }

        public override string GetPath()
        {
            return "════════█+█▒▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "════════██+█▒▒▒▒█╬╬█╬╬█╬╬\n" +
                "═══════░██+██████████████\n" +
                "═══════██+██▀▒▒▒█╬╬█╬╬█╬╬\n" +
                "══════░█+█▒▒▒▒▒▒█╬╬█╬╬█╬█\n" +
                "══════█+██▒▒▒▒▒▒█╬╬█╬╬███\n" +
                "═════█+██▒▒▒▒▒▒▒█╬█████╬╬\n" +
                "════█+██▒▒▒▒▒▒▒▒██╬█╬╬█╬╬\n" +
                "═══█+██▒▒▒▒▒▒▄███╬╬█╬╬█╬╬\n" +
                "═══█+█████████▀═█╬╬█╬╬█╬╬\n" +
                "═█+███══════════█╬╬█╬╬█╬╬\n" +
                "█+███═══════════█╬╬█╬╬█╬╬\n" +
                "████════════════█╬╬█╬╬█╬╬\n" +
                "██══════════════█╬╬█╬╬█╬╬";
        }
    }
}
