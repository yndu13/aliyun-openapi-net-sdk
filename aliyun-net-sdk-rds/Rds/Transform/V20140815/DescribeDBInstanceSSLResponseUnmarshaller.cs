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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceSSLResponseUnmarshaller
    {
        public static DescribeDBInstanceSSLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceSSLResponse describeDBInstanceSSLResponse = new DescribeDBInstanceSSLResponse();

			describeDBInstanceSSLResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceSSLResponse.RequestId = _ctx.StringValue("DescribeDBInstanceSSL.RequestId");
			describeDBInstanceSSLResponse.ConnectionString = _ctx.StringValue("DescribeDBInstanceSSL.ConnectionString");
			describeDBInstanceSSLResponse.SSLExpireTime = _ctx.StringValue("DescribeDBInstanceSSL.SSLExpireTime");
			describeDBInstanceSSLResponse.SSLEnabled = _ctx.StringValue("DescribeDBInstanceSSL.SSLEnabled");
			describeDBInstanceSSLResponse.RequireUpdateReason = _ctx.StringValue("DescribeDBInstanceSSL.RequireUpdateReason");
			describeDBInstanceSSLResponse.CAType = _ctx.StringValue("DescribeDBInstanceSSL.CAType");
			describeDBInstanceSSLResponse.ServerCert = _ctx.StringValue("DescribeDBInstanceSSL.ServerCert");
			describeDBInstanceSSLResponse.ServerKey = _ctx.StringValue("DescribeDBInstanceSSL.ServerKey");
			describeDBInstanceSSLResponse.SSLCreateTime = _ctx.StringValue("DescribeDBInstanceSSL.SSLCreateTime");
			describeDBInstanceSSLResponse.ClientCACert = _ctx.StringValue("DescribeDBInstanceSSL.ClientCACert");
			describeDBInstanceSSLResponse.ClientCACertExpireTime = _ctx.StringValue("DescribeDBInstanceSSL.ClientCACertExpireTime");
			describeDBInstanceSSLResponse.ClientCertRevocationList = _ctx.StringValue("DescribeDBInstanceSSL.ClientCertRevocationList");
			describeDBInstanceSSLResponse.ACL = _ctx.StringValue("DescribeDBInstanceSSL.ACL");
			describeDBInstanceSSLResponse.ReplicationACL = _ctx.StringValue("DescribeDBInstanceSSL.ReplicationACL");
			describeDBInstanceSSLResponse.ServerCAUrl = _ctx.StringValue("DescribeDBInstanceSSL.ServerCAUrl");
			describeDBInstanceSSLResponse.RequireUpdate = _ctx.StringValue("DescribeDBInstanceSSL.RequireUpdate");
			describeDBInstanceSSLResponse.RequireUpdateItem = _ctx.StringValue("DescribeDBInstanceSSL.RequireUpdateItem");
			describeDBInstanceSSLResponse.LastModifyStatus = _ctx.StringValue("DescribeDBInstanceSSL.LastModifyStatus");
			describeDBInstanceSSLResponse.ModifyStatusReason = _ctx.StringValue("DescribeDBInstanceSSL.ModifyStatusReason");
        
			return describeDBInstanceSSLResponse;
        }
    }
}
