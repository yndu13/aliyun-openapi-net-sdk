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
    public class AddCategoryResponseUnmarshaller
    {
        public static AddCategoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddCategoryResponse addCategoryResponse = new AddCategoryResponse();

			addCategoryResponse.HttpResponse = _ctx.HttpResponse;
			addCategoryResponse.RequestId = _ctx.StringValue("AddCategory.RequestId");

			AddCategoryResponse.AddCategory_Category category = new AddCategoryResponse.AddCategory_Category();
			category.CateId = _ctx.LongValue("AddCategory.Category.CateId");
			category.CateName = _ctx.StringValue("AddCategory.Category.CateName");
			category.ParentId = _ctx.LongValue("AddCategory.Category.ParentId");
			category.Level = _ctx.LongValue("AddCategory.Category.Level");
			category.Type = _ctx.StringValue("AddCategory.Category.Type");
			addCategoryResponse.Category = category;
        
			return addCategoryResponse;
        }
    }
}
