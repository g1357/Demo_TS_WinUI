﻿using Microsoft.UI.Xaml.Controls;

namespace Demo_TS_WinUI.Helpers;

public static class FrameExtensions
{
    public static object? GetPageViewModel(this Frame frame) => frame?.Content?.GetType().GetProperty("ViewModel")?.GetValue(frame.Content, null);
}
