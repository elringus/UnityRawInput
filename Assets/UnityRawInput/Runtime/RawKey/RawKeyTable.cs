using System.Collections.Generic;

namespace UnityRawInput
{
    public partial struct RawKey
    {
        private static IReadOnlyDictionary<RawKey, string> allKeys;
        /// <summary>
        /// Specific name attributed to a given <see href="https://docs.google.com/spreadsheets/d/1GSj0gKDxyWAecB3SIyEZ2ssPETZkkxn67gdIwL1zFUs/">keycode</see>
        /// </summary>
        public static IReadOnlyDictionary<RawKey, string> AllKeys
        {
            get => allKeys ?? (allKeys = new Dictionary<RawKey, string>()
            {
                {LeftButton, nameof(LeftButton)},
                {RightButton, nameof(RightButton)},
                {Cancel, nameof(Cancel)},
                {MiddleButton, nameof(MiddleButton)},
                {ExtraButton1, nameof(ExtraButton1)},
                {ExtraButton2, nameof(ExtraButton2)},
                {Back, nameof(Back)},
                {Tab, nameof(Tab)},
                {Clear, nameof(Clear)},
                {Return, nameof(Return)},
                {Shift, nameof(Shift)},
                {Control, nameof(Control)},
                {Menu, nameof(Menu)},
                {Pause, nameof(Pause)},
                {CapsLock, nameof(CapsLock)},
                {Kana, nameof(Kana)},
                {Junja, nameof(Junja)},
                {Final, nameof(Final)},
                {Hanja, nameof(Hanja)},
                {Escape, nameof(Escape)},
                {Convert, nameof(Convert)},
                {NonConvert, nameof(NonConvert)},
                {Accept, nameof(Accept)},
                {ModeChange, nameof(ModeChange)},
                {Space, nameof(Space)},
                {Prior, nameof(Prior)},
                {Next, nameof(Next)},
                {End, nameof(End)},
                {Home, nameof(Home)},
                {Left, nameof(Left)},
                {Up, nameof(Up)},
                {Right, nameof(Right)},
                {Down, nameof(Down)},
                {Select, nameof(Select)},
                {Print, nameof(Print)},
                {Execute, nameof(Execute)},
                {Snapshot, nameof(Snapshot)},
                {Insert, nameof(Insert)},
                {Delete, nameof(Delete)},
                {Help, nameof(Help)},
                {N0, nameof(N0)},
                {N1, nameof(N1)},
                {N2, nameof(N2)},
                {N3, nameof(N3)},
                {N4, nameof(N4)},
                {N5, nameof(N5)},
                {N6, nameof(N6)},
                {N7, nameof(N7)},
                {N8, nameof(N8)},
                {N9, nameof(N9)},
                {A, nameof(A)},
                {B, nameof(B)},
                {C, nameof(C)},
                {D, nameof(D)},
                {E, nameof(E)},
                {F, nameof(F)},
                {G, nameof(G)},
                {H, nameof(H)},
                {I, nameof(I)},
                {J, nameof(J)},
                {K, nameof(K)},
                {L, nameof(L)},
                {M, nameof(M)},
                {N, nameof(N)},
                {O, nameof(O)},
                {P, nameof(P)},
                {Q, nameof(Q)},
                {R, nameof(R)},
                {S, nameof(S)},
                {T, nameof(T)},
                {U, nameof(U)},
                {V, nameof(V)},
                {W, nameof(W)},
                {X, nameof(X)},
                {Y, nameof(Y)},
                {Z, nameof(Z)},
                {LeftWindows, nameof(LeftWindows)},
                {RightWindows, nameof(RightWindows)},
                {Application, nameof(Application)},
                {Sleep, nameof(Sleep)},
                {Numpad0, nameof(Numpad0)},
                {Numpad1, nameof(Numpad1)},
                {Numpad2, nameof(Numpad2)},
                {Numpad3, nameof(Numpad3)},
                {Numpad4, nameof(Numpad4)},
                {Numpad5, nameof(Numpad5)},
                {Numpad6, nameof(Numpad6)},
                {Numpad7, nameof(Numpad7)},
                {Numpad8, nameof(Numpad8)},
                {Numpad9, nameof(Numpad9)},
                {Multiply, nameof(Multiply)},
                {Add, nameof(Add)},
                {Separator, nameof(Separator)},
                {Subtract, nameof(Subtract)},
                {Decimal, nameof(Decimal)},
                {Divide, nameof(Divide)},
                {F1, nameof(F1)},
                {F2, nameof(F2)},
                {F3, nameof(F3)},
                {F4, nameof(F4)},
                {F5, nameof(F5)},
                {F6, nameof(F6)},
                {F7, nameof(F7)},
                {F8, nameof(F8)},
                {F9, nameof(F9)},
                {F10, nameof(F10)},
                {F11, nameof(F11)},
                {F12, nameof(F12)},
                {F13, nameof(F13)},
                {F14, nameof(F14)},
                {F15, nameof(F15)},
                {F16, nameof(F16)},
                {F17, nameof(F17)},
                {F18, nameof(F18)},
                {F19, nameof(F19)},
                {F20, nameof(F20)},
                {F21, nameof(F21)},
                {F22, nameof(F22)},
                {F23, nameof(F23)},
                {F24, nameof(F24)},
                {NumLock, nameof(NumLock)},
                {ScrollLock, nameof(ScrollLock)},
                {Fujitsu_Jisho, nameof(Fujitsu_Jisho)},
                {Fujitsu_Masshou, nameof(Fujitsu_Masshou)},
                {Fujitsu_Touroku, nameof(Fujitsu_Touroku)},
                {Fujitsu_Loya, nameof(Fujitsu_Loya)},
                {Fujitsu_Roya, nameof(Fujitsu_Roya)},
                {LeftButtonAlt, nameof(LeftButtonAlt)},
                {RightButtonAlt, nameof(RightButtonAlt)},
                {WheelLeft, nameof(WheelLeft)},
                {WheelRight, nameof(WheelRight)},
                {WheelDown, nameof(WheelDown)},
                {WheelUp, nameof(WheelUp)},
                {LeftShift, nameof(LeftShift)},
                {RightShift, nameof(RightShift)},
                {LeftControl, nameof(LeftControl)},
                {RightControl, nameof(RightControl)},
                {LeftMenu, nameof(LeftMenu)},
                {RightMenu, nameof(RightMenu)},
                {BrowserBack, nameof(BrowserBack)},
                {BrowserForward, nameof(BrowserForward)},
                {BrowserRefresh, nameof(BrowserRefresh)},
                {BrowserStop, nameof(BrowserStop)},
                {BrowserSearch, nameof(BrowserSearch)},
                {BrowserFavorites, nameof(BrowserFavorites)},
                {BrowserHome, nameof(BrowserHome)},
                {VolumeMute, nameof(VolumeMute)},
                {VolumeDown, nameof(VolumeDown)},
                {VolumeUp, nameof(VolumeUp)},
                {MediaNextTrack, nameof(MediaNextTrack)},
                {MediaPrevTrack, nameof(MediaPrevTrack)},
                {MediaStop, nameof(MediaStop)},
                {MediaPlayPause, nameof(MediaPlayPause)},
                {LaunchMail, nameof(LaunchMail)},
                {LaunchMediaSelect, nameof(LaunchMediaSelect)},
                {LaunchApplication1, nameof(LaunchApplication1)},
                {LaunchApplication2, nameof(LaunchApplication2)},
                {OEM1, nameof(OEM1)},
                {OEMPlus, nameof(OEMPlus)},
                {OEMComma, nameof(OEMComma)},
                {OEMMinus, nameof(OEMMinus)},
                {OEMPeriod, nameof(OEMPeriod)},
                {OEM2, nameof(OEM2)},
                {OEM3, nameof(OEM3)},
                {International1, nameof(International1)},
                {BrazilianComma, nameof(BrazilianComma)},
                {OEM4, nameof(OEM4)},
                {OEM5, nameof(OEM5)},
                {OEM6, nameof(OEM6)},
                {OEM7, nameof(OEM7)},
                {OEM8, nameof(OEM8)},
                {OEMAX, nameof(OEMAX)},
                {OEM102, nameof(OEM102)},
                {ICOHelp, nameof(ICOHelp)},
                {ICO00, nameof(ICO00)},
                {ProcessKey, nameof(ProcessKey)},
                {ICOClear, nameof(ICOClear)},
                {Packet, nameof(Packet)},
                {OEMReset, nameof(OEMReset)},
                {OEMJump, nameof(OEMJump)},
                {OEMPA1, nameof(OEMPA1)},
                {OEMPA2, nameof(OEMPA2)},
                {OEMPA3, nameof(OEMPA3)},
                {OEMWSCtrl, nameof(OEMWSCtrl)},
                {OEMCUSel, nameof(OEMCUSel)},
                {OEMATTN, nameof(OEMATTN)},
                {OEMFinish, nameof(OEMFinish)},
                {OEMCopy, nameof(OEMCopy)},
                {OEMAuto, nameof(OEMAuto)},
                {OEMENLW, nameof(OEMENLW)},
                {OEMBackTab, nameof(OEMBackTab)},
                {ATTN, nameof(ATTN)},
                {CRSel, nameof(CRSel)},
                {EXSel, nameof(EXSel)},
                {EREOF, nameof(EREOF)},
                {Play, nameof(Play)},
                {Zoom, nameof(Zoom)},
                {Noname, nameof(Noname)},
                {PA1, nameof(PA1)},
                {OEMClear, nameof(OEMClear)},
                {International2, nameof(International2)},
                {International4, nameof(International4)},
                {International3, nameof(International3)}
            });
        }
    }
}
