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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetAITemplateResponseUnmarshaller
    {
        public static GetAITemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAITemplateResponse getAITemplateResponse = new GetAITemplateResponse();

			getAITemplateResponse.HttpResponse = _ctx.HttpResponse;
			getAITemplateResponse.RequestId = _ctx.StringValue("GetAITemplate.RequestId");

			GetAITemplateResponse.GetAITemplate_TemplateInfo templateInfo = new GetAITemplateResponse.GetAITemplate_TemplateInfo();
			templateInfo.TemplateId = _ctx.StringValue("GetAITemplate.TemplateInfo.TemplateId");
			templateInfo.TemplateType = _ctx.StringValue("GetAITemplate.TemplateInfo.TemplateType");
			templateInfo.TemplateName = _ctx.StringValue("GetAITemplate.TemplateInfo.TemplateName");
			templateInfo.TemplateConfig = _ctx.StringValue("GetAITemplate.TemplateInfo.TemplateConfig");
			templateInfo.Source = _ctx.StringValue("GetAITemplate.TemplateInfo.Source");
			templateInfo.IsDefault = _ctx.StringValue("GetAITemplate.TemplateInfo.IsDefault");
			templateInfo.CreationTime = _ctx.StringValue("GetAITemplate.TemplateInfo.CreationTime");
			templateInfo.ModifyTime = _ctx.StringValue("GetAITemplate.TemplateInfo.ModifyTime");
			getAITemplateResponse.TemplateInfo = templateInfo;
        
			return getAITemplateResponse;
        }
    }
}
