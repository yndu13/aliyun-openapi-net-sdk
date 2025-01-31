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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnSMCertificateDetailResponseUnmarshaller
    {
        public static DescribeCdnSMCertificateDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnSMCertificateDetailResponse describeCdnSMCertificateDetailResponse = new DescribeCdnSMCertificateDetailResponse();

			describeCdnSMCertificateDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnSMCertificateDetailResponse.RequestId = _ctx.StringValue("DescribeCdnSMCertificateDetail.RequestId");
			describeCdnSMCertificateDetailResponse.SignCertificate = _ctx.StringValue("DescribeCdnSMCertificateDetail.SignCertificate");
			describeCdnSMCertificateDetailResponse.EncryptCertificate = _ctx.StringValue("DescribeCdnSMCertificateDetail.EncryptCertificate");
			describeCdnSMCertificateDetailResponse.CertIdentifier = _ctx.StringValue("DescribeCdnSMCertificateDetail.CertIdentifier");
			describeCdnSMCertificateDetailResponse.CertName = _ctx.StringValue("DescribeCdnSMCertificateDetail.CertName");
			describeCdnSMCertificateDetailResponse.CommonName = _ctx.StringValue("DescribeCdnSMCertificateDetail.CommonName");
			describeCdnSMCertificateDetailResponse.Sans = _ctx.StringValue("DescribeCdnSMCertificateDetail.Sans");
			describeCdnSMCertificateDetailResponse.CertOrg = _ctx.StringValue("DescribeCdnSMCertificateDetail.CertOrg");
			describeCdnSMCertificateDetailResponse.CertExpireTime = _ctx.StringValue("DescribeCdnSMCertificateDetail.CertExpireTime");
        
			return describeCdnSMCertificateDetailResponse;
        }
    }
}
