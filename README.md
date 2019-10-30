NAudio is an open source .NET audio library written by [Mark Heath](https://markheath.net)

![NAudio logo](naudio-logo.png)

## Features

* Play back audio using a variety of APIs
    * WaveOut
    * DirectSound
    * ASIO
    * WASAPI
* Read audio from many standard file formats 
    * WAV
    * AIFF
    * MP3 (using ACM, DMO or MFT)
    * G.711 mu-law and a-law
    * ADPCM, G.722, Speex (using NSpeex)
    * WMA, AAC, MP4 and more others with Media Foundation
* Convert between various forms of uncompressed audio
    * Change the number of channels - Mono to stereo, stereo to mono
    * Modify bit depth (8, 16, 24, 32 integer or 32 bit IEEE float)
    * Resample audio using a choice of resampling algorithms
* Encode audio using any ACM or Media Foundation codec installed on your computer
    * Create MP3s (Windows 8 and above)
    * Create AAC/MP4 audio (Windows 7 and above)
    * Create WMA files
    * Create WAV files containing G.711, ADPCM, G.722, etc.
* Mix and manipulate audio streams using a 32-bit floating mixing engine
    * construct signal chains 
    * examine sample levels for the purposes of metering or waveform rendering
    * pass blocks of samples through an FFT for metering or DSP
    * delay, loop, or fade audio in and out
    * Perform EQ with a BiQuad filter (allowing low pass, high pass, peaking EQ, etc.)
    * Pitch shifting of audio with a phase vocoder
* Record audio using a variety of capture APIs
    * WaveIn
    * WASAPI
    * ASIO
* Record system audio with WASAPI Capture
* Work with soundcards
    * Enumerate devices
    * Access soundcard controls and metering information
* Full MIDI event model
    * Read and write MIDI files
    * Respond to received MIDI events
    * Send MIDI events
* An extensible programming model
    * All base classes easily inherited from for you to add your custom components
* Support for UWP (preliminary)
    * Create Windows 8 Store apps and Windows Universal apps

## Getting Started

The easiest way to install NAudio into your project is to install the latest [NAudio NuGet package](https://www.nuget.org/packages/NAudio/). Prerelease versions of NAudio are also often made available on NuGet.

Alternatively, you can download the latest release in binary format from [here](https://github.com/naudio/NAudio/releases).

NAudio comes with several demo applications which are the quickest way to see how to use the various features of NAudio. You can download compiled demo applications from [here](https://github.com/naudio/NAudio/releases), and explore the source code [here](https://github.com/naudio/NAudio/tree/master/NAudioDemo).

## Tutorials

### Playback
 - [Playing an Audio File from a WinForms application](Docs/PlayAudioFileWinForms.md)
 - [Playing an Audio File from a Console application](Docs/PlayAudioFileConsoleApp.md)
 - [Playing Audio from a URL](Docs/PlayAudioFromUrl.md)
 - [Choose an audio output device type](Docs/OutputDeviceTypes.md)
 - [Enumerate and select Output Devices](Docs/EnumerateOutputDevices.md)
 - [Creating and configuring a WasapiOut device](Docs/WasapiOut.md)
 - [Implement "Fire and Forget" Playback (e.g. game sound effects)](http://markheath.net/post/fire-and-forget-audio-playback-with)
 - [Play streaming MP3](http://markheath.net/post/how-to-play-back-streaming-mp3-using)
 - [Handling playback stopped](Docs/PlaybackStopped.md)
 - [Understanding WaveStream, IWavePlayer and ISampleProvider](Docs/WaveProviders.md)
 - [Playing Audio with ASIO](Docs/AsioPlayback.md)

### Working with Codecs

 - [Convert an MP3 to WAV](Docs/ConvertMp3ToWav.md)
 - [Encode to MP3 and other formats using MediaFoundationEncoder](Docs/MediaFoundationEncoder.md)
    - [More examples](http://markheath.net/post/naudio-mediafoundationencoder)
 - [Understand how to convert between any audio formats you have codecs for](http://www.codeproject.com/Articles/501521/How-to-convert-between-most-audio-formats-in-NET)
 - [Enumerate Media Foundation Transforms (MFTs)](Docs/EnumerateMediaFoundationTransforms.md)
 - [Enumerate ACM Codecs](Docs/EnumerateAcmDrivers.md)
 - [Fix the NoDriver calling acmFormatSuggest issue](http://markheath.net/post/nodriver-calling-acmformatsuggest)

### Working with audio files

 - [Mix Two Audio Files to WAV](Docs/MixTwoAudioFilesToWav.md)
 - [Trim a WAV File](http://markheath.net/post/trimming-wav-file-using-naudio)
 - [Merge MP3 Files](http://markheath.net/post/merging-mp3-files-with-naudio-in-c-and)
 - [Convert an AIFF file to WAV](http://markheath.net/post/how-to-convert-aiff-files-to-wav-using)
 - [Use the WavFileWriter class](http://markheath.net/post/how-to-use-wavefilewriter)
 - [Create an ID3v2 tag](http://naudio.codeplex.com/wikipage?title=Create%20an%20ID3v2%20Tag)

### Manipulating audio

 - [Convert between mono and stereo](Docs/ConvertBetweenStereoAndMono.md)
 - [Concatenating Audio](Docs/ConcatenatingAudio.md)
 - [Skip and Take Using OffsetSampleProvider](Docs/OffsetSampleProvider.md)
 - [Implement Looped Playback](http://markheath.net/post/looped-playback-in-net-with-naudio)
 - [Work with Multi-Channel Audio](http://markheath.net/post/handling-multi-channel-audio-in-naudio)
 - [Resample Audio](Docs/Resampling.md)
 - [Input driven Audio Resampling](http://markheath.net/post/input-driven-resampling-with-naudio-using-acm)
 - [Using RawSourceWaveStream](Docs/RawSourceWaveStream.md)
 - [Adjust the pitch of audio using SmbPitchShiftingSampleProvider](Docs/SmbPitchShiftingSampleProvider.md)
 - [Varispeed playback with NAudio using SoundTouch](http://markheath.net/post/varispeed-naudio-soundtouch)
 - [Fade audio in and out](Docs/FadeInOutSampleProvider.md)

### Generating audio

 - [Play Sine Waves and other signal types](Docs/PlaySineWave.md)
 - [Implement sine wave with portamento](http://markheath.net/post/naudio-sine-portamento)

### Recording

 - [Recording a WAV file from a WinForms application](Docs/RecordWavFileWinFormsWaveIn.md)
 - [Capturing system audio with WasapiLoopbackCapture](Docs/WasapiLoopbackCapture.md)
 - [Play and Record audio at the same time](http://markheath.net/post/how-to-record-and-play-audio-at-same)
 - [Record Audio with ASIO](Docs/AsioRecording.md)

### Visualization

 - [WaveForm Rendering to PNG](Docs/WaveFormRendering.md)
 - [Implement a Recording Level Meter](Docs/RecordingLevelMeter.md)

### MIDI

 - [Sending and Receiving MIDI Events](Docs/MidiInAndOut.md)
 - [Exploring MIDI Files with MidiFile](Docs/MidiFile.md)
 - [MIDI Event types](Docs/MidiEvent.md)

### More...

Additional sources of documentation for NAudio are:
 - [Original Documentation on CodePlex](http://naudio.codeplex.com/documentation)
 - [NAudio articles on Mark Heath's blog](http://markheath.net/category/naudio)

## NAudio Training Courses

If you want to get up to speed as quickly as possible with NAudio programming, I recommend you watch these two Pluralsight courses. You will need to be a subscriber to access the content, but there is 10 hours of training material on NAudio, and it also will give you access to their vast training library on other programming topics.

- [Digital Audio Fundamentals](http://pluralsight.com/training/Courses/TableOfContents/digital-audio-fundamentals)
- [Audio Programming with NAudio](http://pluralsight.com/training/Courses/TableOfContents/audio-programming-naudio)

To be successful developing applications that process digital audio, there are some key concepts that you need to understand. To help developers quickly get up to speed with what they need to know before trying to use NAudio, I have created the [Digital Audio Fundamentals](http://pluralsight.com/training/Courses/TableOfContents/digital-audio-fundamentals) course, which covers sample rates, bit depths, file formats, codecs, decibels, clipping, aliasing, synthesis, visualisations, effects and much more. In particular, the fourth module on signal chains is vital background information if you are to be effective with NAudio. 

[Audio Programming with NAudio](http://pluralsight.com/training/Courses/TableOfContents/audio-programming-naudio) is a follow-on course which contains seven hours of training material covering all the major features of NAudio. It is highly recommended that you take this course if you intend to create an application with NAudio.

## How do I...?

The best way to learn how to use NAudio is to download the source code and look at the two demo applications - [NAudioDemo](https://github.com/naudio/NAudio/tree/master/NAudioDemo) and [NAudioWpfDemo](https://github.com/naudio/NAudio/tree/master/NAudioWpfDemo). These demonstrate several of the key capabilities of the NAudio framework. They also have the advantage of being kept up to date, whilst some of the tutorials you will find on the internet refer to old versions of NAudio.

## FAQ

**What is NAudio?**

NAudio is an open source audio API for .NET written in C# by Mark Heath, with contributions from many other developers. It is intended to provide a comprehensive set of useful utility classes from which you can construct your own audio application.

**Why NAudio?**

NAudio was created because the Framework Class Library that shipped with .NET 1.0 had no support for playing audio. The System.Media namespace introduced in .NET 2.0 provided a small amount of support, and the MediaElement in WPF and Silverlight took that a bit further. The vision behind NAudio is to provide a comprehensive set of audio related classes allowing easy development of utilities that play or record audio, or manipulate audio files in some way.

**Can I Use NAudio in my Project?**

NAudio is licensed under the Microsoft Public License (Ms-PL) which means that you can use it in whatever project you like including commercial projects. Of course we would love it if you share any bug-fixes or enhancements you made to the original NAudio project files.

**Is .NET Performance Good Enough for Audio?**

While .NET cannot compete with unmanaged languages for very low latency audio work, it still performs better than many people would expect. On a fairly modest PC, you can quite easily mix multiple WAV files together, including pass them through various effects and codecs, play back glitch free with a latency of around 50ms.

**How can I get help?**

There are three main ways to get help. First, you can raise an issue here on GitHub. This is the best option when you've written some code and want to ask why it's not working as you expect. I attempt to answer all questions, but since this is a spare time project, occasionally I get behind. 

You can also ask on StackOverflow and [tag your question with naudio](http://stackoverflow.com/questions/tagged/naudio), if your question is a "how do I..." sort of question. This gives you a better chance of getting a quick answer. Please try to search first to see if your question has already been answered elsewhere.

Finally, I am occasionally able to offer paid support for situations where you need quick advice, bugfixes or new features. Please contact Mark Heath directly if you wish to pursue this option.

**How do I submit a patch?**

I welcome contributions to NAudio and have accepted many patches, but if you want your code to be included, please familiarise yourself with the following guidelines:

 - Your submission must be your own work, and able to be released under the MS-PL license.
 - You will need to make sure your code conforms to the layout and naming conventions used elsewhere in NAudio.
 - Remember that there are many existing users of NAudio. A patch that changes the public interface is not likely to be accepted.
 - Try to write "clean code" - avoid long functions and long classes. Try to add a new feature by creating a new class rather than putting loads of extra code inside an existing one.
 - I don't usually accept contributions I can't test, so please write unit tests (using NUnit) if at all possible. If not, give a clear explanation of how your feature can be unit tested and provide test data if appropriate. Tell me what you did to test it yourself, including what operating systems and soundcards you used.
 - If you are adding a new feature, please consider writing a short tutorial on how to use it.
 - Unless your patch is a small bugfix, I will code review it and give you feedback. You will need to be willing to make the recommended changes before it can be integrated into the main code.
 - Patches should be provided using the Pull Request feature of GitHub.
 - Please also bear in mind that when you add a feature to NAudio, that feature will generate future support requests and bug reports. Are you willing to stick around on the forums and help out people using it?




                 Apache License
                           Version 2.0, January 2004
                        https://www.apache.org/licenses/

   TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION

   1. Definitions.

      "License" shall mean the terms and conditions for use, reproduction,
      and distribution as defined by Sections 1 through 9 of this document.

      "Licensor" shall mean the copyright owner or entity authorized by
      the copyright owner that is granting the License.

      "Legal Entity" shall mean the union of the acting entity and all
      other entities that control, are controlled by, or are under common
      control with that entity. For the purposes of this definition,
      "control" means (i) the power, direct or indirect, to cause the
      direction or management of such entity, whether by contract or
      otherwise, or (ii) ownership of fifty percent (50%) or more of the
      outstanding shares, or (iii) beneficial ownership of such entity.

      "You" (or "Your") shall mean an individual or Legal Entity
      exercising permissions granted by this License.

      "Source" form shall mean the preferred form for making modifications,
      including but not limited to software source code, documentation
      source, and configuration files.

      "Object" form shall mean any form resulting from mechanical
      transformation or translation of a Source form, including but
      not limited to compiled object code, generated documentation,
      and conversions to other media types.

      "Work" shall mean the work of authorship, whether in Source or
      Object form, made available under the License, as indicated by a
      copyright notice that is included in or attached to the work
      (an example is provided in the Appendix below).

      "Derivative Works" shall mean any work, whether in Source or Object
      form, that is based on (or derived from) the Work and for which the
      editorial revisions, annotations, elaborations, or other modifications
      represent, as a whole, an original work of authorship. For the purposes
      of this License, Derivative Works shall not include works that remain
      separable from, or merely link (or bind by name) to the interfaces of,
      the Work and Derivative Works thereof.

      "Contribution" shall mean any work of authorship, including
      the original version of the Work and any modifications or additions
      to that Work or Derivative Works thereof, that is intentionally
      submitted to Licensor for inclusion in the Work by the copyright owner
      or by an individual or Legal Entity authorized to submit on behalf of
      the copyright owner. For the purposes of this definition, "submitted"
      means any form of electronic, verbal, or written communication sent
      to the Licensor or its representatives, including but not limited to
      communication on electronic mailing lists, source code control systems,
      and issue tracking systems that are managed by, or on behalf of, the
      Licensor for the purpose of discussing and improving the Work, but
      excluding communication that is conspicuously marked or otherwise
      designated in writing by the copyright owner as "Not a Contribution."

      "Contributor" shall mean Licensor and any individual or Legal Entity
      on behalf of whom a Contribution has been received by Licensor and
      subsequently incorporated within the Work.

   2. Grant of Copyright License. Subject to the terms and conditions of
      this License, each Contributor hereby grants to You a perpetual,
      worldwide, non-exclusive, no-charge, royalty-free, irrevocable
      copyright license to reproduce, prepare Derivative Works of,
      publicly display, publicly perform, sublicense, and distribute the
      Work and such Derivative Works in Source or Object form.

   3. Grant of Patent License. Subject to the terms and conditions of
      this License, each Contributor hereby grants to You a perpetual,
      worldwide, non-exclusive, no-charge, royalty-free, irrevocable
      (except as stated in this section) patent license to make, have made,
      use, offer to sell, sell, import, and otherwise transfer the Work,
      where such license applies only to those patent claims licensable
      by such Contributor that are necessarily infringed by their
      Contribution(s) alone or by combination of their Contribution(s)
      with the Work to which such Contribution(s) was submitted. If You
      institute patent litigation against any entity (including a
      cross-claim or counterclaim in a lawsuit) alleging that the Work
      or a Contribution incorporated within the Work constitutes direct
      or contributory patent infringement, then any patent licenses
      granted to You under this License for that Work shall terminate
      as of the date such litigation is filed.

   4. Redistribution. You may reproduce and distribute copies of the
      Work or Derivative Works thereof in any medium, with or without
      modifications, and in Source or Object form, provided that You
      meet the following conditions:

      (a) You must give any other recipients of the Work or
          Derivative Works a copy of this License; and

      (b) You must cause any modified files to carry prominent notices
          stating that You changed the files; and

      (c) You must retain, in the Source form of any Derivative Works
          that You distribute, all copyright, patent, trademark, and
          attribution notices from the Source form of the Work,
          excluding those notices that do not pertain to any part of
          the Derivative Works; and

      (d) If the Work includes a "NOTICE" text file as part of its
          distribution, then any Derivative Works that You distribute must
          include a readable copy of the attribution notices contained
          within such NOTICE file, excluding those notices that do not
          pertain to any part of the Derivative Works, in at least one
          of the following places: within a NOTICE text file distributed
          as part of the Derivative Works; within the Source form or
          documentation, if provided along with the Derivative Works; or,
          within a display generated by the Derivative Works, if and
          wherever such third-party notices normally appear. The contents
          of the NOTICE file are for informational purposes only and
          do not modify the License. You may add Your own attribution
          notices within Derivative Works that You distribute, alongside
          or as an addendum to the NOTICE text from the Work, provided
          that such additional attribution notices cannot be construed
          as modifying the License.

      You may add Your own copyright statement to Your modifications and
      may provide additional or different license terms and conditions
      for use, reproduction, or distribution of Your modifications, or
      for any such Derivative Works as a whole, provided Your use,
      reproduction, and distribution of the Work otherwise complies with
      the conditions stated in this License.

   5. Submission of Contributions. Unless You explicitly state otherwise,
      any Contribution intentionally submitted for inclusion in the Work
      by You to the Licensor shall be under the terms and conditions of
      this License, without any additional terms or conditions.
      Notwithstanding the above, nothing herein shall supersede or modify
      the terms of any separate license agreement you may have executed
      with Licensor regarding such Contributions.

   6. Trademarks. This License does not grant permission to use the trade
      names, trademarks, service marks, or product names of the Licensor,
      except as required for reasonable and customary use in describing the
      origin of the Work and reproducing the content of the NOTICE file.

   7. Disclaimer of Warranty. Unless required by applicable law or
      agreed to in writing, Licensor provides the Work (and each
      Contributor provides its Contributions) on an "AS IS" BASIS,
      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
      implied, including, without limitation, any warranties or conditions
      of TITLE, NON-INFRINGEMENT, MERCHANTABILITY, or FITNESS FOR A
      PARTICULAR PURPOSE. You are solely responsible for determining the
      appropriateness of using or redistributing the Work and assume any
      risks associated with Your exercise of permissions under this License.

   8. Limitation of Liability. In no event and under no legal theory,
      whether in tort (including negligence), contract, or otherwise,
      unless required by applicable law (such as deliberate and grossly
      negligent acts) or agreed to in writing, shall any Contributor be
      liable to You for damages, including any direct, indirect, special,
      incidental, or consequential damages of any character arising as a
      result of this License or out of the use or inability to use the
      Work (including but not limited to damages for loss of goodwill,
      work stoppage, computer failure or malfunction, or any and all
      other commercial damages or losses), even if such Contributor
      has been advised of the possibility of such damages.

   9. Accepting Warranty or Additional Liability. While redistributing
      the Work or Derivative Works thereof, You may choose to offer,
      and charge a fee for, acceptance of support, warranty, indemnity,
      or other liability obligations and/or rights consistent with this
      License. However, in accepting such obligations, You may act only
      on Your own behalf and on Your sole responsibility, not on behalf
      of any other Contributor, and only if You agree to indemnify,
      defend, and hold each Contributor harmless for any liability
      incurred by, or claims asserted against, such Contributor by reason
      of your accepting any such warranty or additional liability.

   END OF TERMS AND CONDITIONS

   APPENDIX: How to apply the Apache License to your work.

      To apply the Apache License to your work, attach the following
      boilerplate notice, with the fields enclosed by brackets "[]"
      replaced with your own identifying information. (Don't include
      the brackets!)  The text should be enclosed in the appropriate
      comment syntax for the file format. We also recommend that a
      file or class name and description of purpose be included on the
      same "printed page" as the copyright notice for easier
      identification within third-party archives.

   Copyright 2019 Rolando Gopez Lacuata.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       https://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
