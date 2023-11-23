﻿using System;

namespace GetProcHandleClient.Interop
{
    using NTSTATUS = Int32;

    internal class Win32Consts
    {
        public const NTSTATUS STATUS_SUCCESS = 0;
        public const int ERROR_INSUFFICIENT_BUFFER = 122;
    }
}
