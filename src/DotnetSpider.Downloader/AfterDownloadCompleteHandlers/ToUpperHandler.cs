﻿namespace DotnetSpider.Downloader.AfterDownloadCompleteHandlers
{
	/// <summary>
	/// Handler that make <see cref="Response"/> to uppercase.
	/// </summary>
	/// <summary xml:lang="zh-CN">
	/// 所有内容转化成大写
	/// </summary>
	public class ToUpperHandler : AfterDownloadCompleteHandler
	{
		/// <summary>
		/// make <see cref="Response"/> to uppercase.
		/// </summary>
		/// <summary xml:lang="zh-CN">
		/// 所有内容转化成大写
		/// </summary>
		/// <param name="response">页面数据 <see cref="Response"/></param>
		/// <param name="downloader">下载器 <see cref="IDownloader"/></param>
		public override void Handle(ref Response response, IDownloader downloader)
		{
			var text = response.Content?.ToString();
			if (string.IsNullOrWhiteSpace(text))
			{
				return;
			}
			response.Content = text.ToUpper();
		}
	}
}
