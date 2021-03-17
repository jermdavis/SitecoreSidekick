﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidekick.Core.Services.Interface
{
	public interface IHttpClientService
	{
		Task<string> Post(string url, string content);
	}
}
