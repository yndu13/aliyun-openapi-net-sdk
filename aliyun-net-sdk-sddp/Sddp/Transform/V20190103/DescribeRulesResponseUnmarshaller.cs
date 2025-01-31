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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeRulesResponseUnmarshaller
    {
        public static DescribeRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRulesResponse describeRulesResponse = new DescribeRulesResponse();

			describeRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeRulesResponse.RequestId = _ctx.StringValue("DescribeRules.RequestId");
			describeRulesResponse.PageSize = _ctx.IntegerValue("DescribeRules.PageSize");
			describeRulesResponse.CurrentPage = _ctx.IntegerValue("DescribeRules.CurrentPage");
			describeRulesResponse.TotalCount = _ctx.IntegerValue("DescribeRules.TotalCount");

			List<DescribeRulesResponse.DescribeRules_Rule> describeRulesResponse_items = new List<DescribeRulesResponse.DescribeRules_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeRules.Items.Length"); i++) {
				DescribeRulesResponse.DescribeRules_Rule rule = new DescribeRulesResponse.DescribeRules_Rule();
				rule.Id = _ctx.LongValue("DescribeRules.Items["+ i +"].Id");
				rule.GmtCreate = _ctx.LongValue("DescribeRules.Items["+ i +"].GmtCreate");
				rule.GmtModified = _ctx.LongValue("DescribeRules.Items["+ i +"].GmtModified");
				rule.CustomType = _ctx.IntegerValue("DescribeRules.Items["+ i +"].CustomType");
				rule.Name = _ctx.StringValue("DescribeRules.Items["+ i +"].Name");
				rule.Description = _ctx.StringValue("DescribeRules.Items["+ i +"].Description");
				rule.UserId = _ctx.LongValue("DescribeRules.Items["+ i +"].UserId");
				rule.LoginName = _ctx.StringValue("DescribeRules.Items["+ i +"].LoginName");
				rule.DisplayName = _ctx.StringValue("DescribeRules.Items["+ i +"].DisplayName");
				rule.Category = _ctx.IntegerValue("DescribeRules.Items["+ i +"].Category");
				rule.CategoryName = _ctx.StringValue("DescribeRules.Items["+ i +"].CategoryName");
				rule.Status = _ctx.IntegerValue("DescribeRules.Items["+ i +"].Status");
				rule.RiskLevelName = _ctx.StringValue("DescribeRules.Items["+ i +"].RiskLevelName");
				rule.RiskLevelId = _ctx.LongValue("DescribeRules.Items["+ i +"].RiskLevelId");
				rule.Content = _ctx.StringValue("DescribeRules.Items["+ i +"].Content");
				rule.DepartName = _ctx.StringValue("DescribeRules.Items["+ i +"].DepartName");
				rule.StatExpress = _ctx.StringValue("DescribeRules.Items["+ i +"].StatExpress");
				rule.ProductId = _ctx.LongValue("DescribeRules.Items["+ i +"].ProductId");
				rule.HitTotalCount = _ctx.IntegerValue("DescribeRules.Items["+ i +"].HitTotalCount");
				rule.ProductCode = _ctx.StringValue("DescribeRules.Items["+ i +"].ProductCode");
				rule.WarnLevel = _ctx.IntegerValue("DescribeRules.Items["+ i +"].WarnLevel");
				rule.MajorKey = _ctx.StringValue("DescribeRules.Items["+ i +"].MajorKey");
				rule.ContentCategory = _ctx.StringValue("DescribeRules.Items["+ i +"].ContentCategory");
				rule.Target = _ctx.StringValue("DescribeRules.Items["+ i +"].Target");
				rule.GroupId = _ctx.StringValue("DescribeRules.Items["+ i +"].GroupId");

				describeRulesResponse_items.Add(rule);
			}
			describeRulesResponse.Items = describeRulesResponse_items;
        
			return describeRulesResponse;
        }
    }
}
