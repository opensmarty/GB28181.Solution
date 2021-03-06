﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Win.GB28181.Client.Player.Analyzer
{

    public class MediaFramePacket
    {
        /// <summary>
        /// 数据
        /// </summary>
        public byte[] Buffer { get; set; }
        /// <summary>
        /// 媒体类型
        /// </summary>
        public MediaType MediaType { get; set; }
        /// <summary>
        /// 编码时间
        /// </summary>
        public long EncodTime { get; set; }
        /// <summary>
        /// 视频编码帧率
        /// </summary>
        public ushort FrameRate { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        public ushort Width { get; set; }
        /// <summary>
        /// 高度
        /// </summary>
        public ushort Height { get; set; }
        /// <summary>
        /// 音频采样率
        /// </summary>
        public ushort SampleRate { get; set; }
        /// <summary>
        /// 是否1（i帧）,0为p帧 
        /// </summary>
        public byte KeyFrame { get; set; }
 
        public int Ex { get; set; }

      

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffer">数据</param>
        /// <param name="mediaType">数据类型</param>
        /// <param name="encodeTime">编码时间</param>
        /// <param name="framRate">帧率</param>
        /// <param name="keyFrame">是否为关键帧</param>
        public MediaFramePacket( byte[] buffer, MediaType mediaType, long encodeTime, ushort framRate, byte keyFrame, ushort width, ushort height)
        {
            this.Buffer = buffer;
            this.MediaType = mediaType;
            this.EncodTime = encodeTime;
            this.FrameRate = framRate;
            this.KeyFrame = keyFrame;
            this.Width = width;
            this.Height = height;
           
        }
   
        public MediaFramePacket() { }


    }
    public enum MediaType : ushort
    {
        VideoES,
        AudioES,
        TS,
        MP4
    }
}
