/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20201112;

namespace Aliyun.Acs.Cloudauth.Model.V20201112
{
    public class CompareFacesRequest : RpcAcsRequest<CompareFacesResponse>
    {
        public CompareFacesRequest()
            : base("Cloudauth", "2020-11-12", "CompareFaces", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string targetImageUrl;

		private string sourceImageUrl;

		private string targetImageBase64;

		private string bizType;

		private string bizId;

		private string sourceImageBase64;

		public string TargetImageUrl
		{
			get
			{
				return targetImageUrl;
			}
			set	
			{
				targetImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "TargetImageUrl", value);
			}
		}

		public string SourceImageUrl
		{
			get
			{
				return sourceImageUrl;
			}
			set	
			{
				sourceImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "SourceImageUrl", value);
			}
		}

		public string TargetImageBase64
		{
			get
			{
				return targetImageBase64;
			}
			set	
			{
				targetImageBase64 = value;
				DictionaryUtil.Add(BodyParameters, "TargetImageBase64", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(BodyParameters, "BizType", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(BodyParameters, "BizId", value);
			}
		}

		public string SourceImageBase64
		{
			get
			{
				return sourceImageBase64;
			}
			set	
			{
				sourceImageBase64 = value;
				DictionaryUtil.Add(BodyParameters, "SourceImageBase64", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CompareFacesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CompareFacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
