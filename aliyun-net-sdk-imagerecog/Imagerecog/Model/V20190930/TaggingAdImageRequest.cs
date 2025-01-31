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
using Aliyun.Acs.imagerecog.Transform;
using Aliyun.Acs.imagerecog.Transform.V20190930;

namespace Aliyun.Acs.imagerecog.Model.V20190930
{
    public class TaggingAdImageRequest : RpcAcsRequest<TaggingAdImageResponse>
    {
        public TaggingAdImageRequest()
            : base("imagerecog", "2019-09-30", "TaggingAdImage", "imagerecog", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imagerecog.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imagerecog.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string imageURL;

		public string ImageURL
		{
			get
			{
				return imageURL;
			}
			set	
			{
				imageURL = value;
				DictionaryUtil.Add(BodyParameters, "ImageURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TaggingAdImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TaggingAdImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
