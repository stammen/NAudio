using System;

namespace NAudio.CoreAudioApi
{
    /// <summary>
    /// AUDCLNT_STREAMFLAGS
    /// </summary>
    [Flags]
    public enum AudioClientStreamFlags : uint
    {
        /// <summary>
        /// None
        /// </summary>
        None,
        /// <summary>
        /// AUDCLNT_STREAMFLAGS_CROSSPROCESS
        /// </summary>
        CrossProcess = 0x00010000,
        /// <summary>
        /// AUDCLNT_STREAMFLAGS_LOOPBACK
        /// </summary>
        Loopback = 0x00020000,
        /// <summary>
        /// AUDCLNT_STREAMFLAGS_EVENTCALLBACK 
        /// </summary>
        EventCallback = 0x00040000,
        /// <summary>
        /// AUDCLNT_STREAMFLAGS_NOPERSIST     
        /// </summary>
        NoPersist = 0x00080000,
        /// <summary>
        /// AUDCLNT_STREAMFLAGS_SRC_DEFAULT_QUALITY     
        /// </summary>
        AUDCLNT_STREAMFLAGS_SRC_DEFAULT_QUALITY = 0x08000000,
        /// AUDCLNT_STREAMFLAGS_AUTOCONVERTPCM     
        /// </summary>
        AUDCLNT_STREAMFLAGS_AUTOCONVERTPCM = 0x80000000,
    }
}
