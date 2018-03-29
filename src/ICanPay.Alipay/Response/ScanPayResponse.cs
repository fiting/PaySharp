﻿namespace ICanPay.Alipay.Response
{
    public class ScanPayResponse : BaseResponse
    {
        /// <summary>
        /// 当前预下单请求生成的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码
        /// </summary>
        public string QrCode { get; set; }
    }
}
