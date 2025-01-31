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
using Aliyun.Acs.alimt;
using Aliyun.Acs.alimt.Transform;
using Aliyun.Acs.alimt.Transform.V20181012;

namespace Aliyun.Acs.alimt.Model.V20181012
{
    public class TranslateECommerceRequest : RpcAcsRequest<TranslateECommerceResponse>
    {
        public TranslateECommerceRequest()
            : base("alimt", "2018-10-12", "TranslateECommerce")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alimt.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceLanguage;

		private string sourceText;

		private string formatType;

		private string scene;

		private string targetLanguage;

		public string SourceLanguage
		{
			get
			{
				return sourceLanguage;
			}
			set	
			{
				sourceLanguage = value;
				DictionaryUtil.Add(BodyParameters, "SourceLanguage", value);
			}
		}

		public string SourceText
		{
			get
			{
				return sourceText;
			}
			set	
			{
				sourceText = value;
				DictionaryUtil.Add(BodyParameters, "SourceText", value);
			}
		}

		public string FormatType
		{
			get
			{
				return formatType;
			}
			set	
			{
				formatType = value;
				DictionaryUtil.Add(BodyParameters, "FormatType", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(BodyParameters, "Scene", value);
			}
		}

		public string TargetLanguage
		{
			get
			{
				return targetLanguage;
			}
			set	
			{
				targetLanguage = value;
				DictionaryUtil.Add(BodyParameters, "TargetLanguage", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TranslateECommerceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TranslateECommerceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
