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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListColumnsResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListColumns_Column> columnList;

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		[JsonProperty(PropertyName = "Success")]
		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		[JsonProperty(PropertyName = "ColumnList")]
		public List<ListColumns_Column> ColumnList
		{
			get
			{
				return columnList;
			}
			set	
			{
				columnList = value;
			}
		}

		public class ListColumns_Column
		{

			private string columnId;

			private string columnName;

			private string defaultValue;

			private string description;

			private string columnType;

			private bool? autoIncrement;

			private string functionType;

			private string securityLevel;

			private long? dataLength;

			private int? dataScale;

			private int? dataPrecision;

			private bool? sensitive;

			private bool? nullable;

			[JsonProperty(PropertyName = "ColumnId")]
			public string ColumnId
			{
				get
				{
					return columnId;
				}
				set	
				{
					columnId = value;
				}
			}

			[JsonProperty(PropertyName = "ColumnName")]
			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
				}
			}

			[JsonProperty(PropertyName = "DefaultValue")]
			public string DefaultValue
			{
				get
				{
					return defaultValue;
				}
				set	
				{
					defaultValue = value;
				}
			}

			[JsonProperty(PropertyName = "Description")]
			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			[JsonProperty(PropertyName = "ColumnType")]
			public string ColumnType
			{
				get
				{
					return columnType;
				}
				set	
				{
					columnType = value;
				}
			}

			[JsonProperty(PropertyName = "AutoIncrement")]
			public bool? AutoIncrement
			{
				get
				{
					return autoIncrement;
				}
				set	
				{
					autoIncrement = value;
				}
			}

			[JsonProperty(PropertyName = "FunctionType")]
			public string FunctionType
			{
				get
				{
					return functionType;
				}
				set	
				{
					functionType = value;
				}
			}

			[JsonProperty(PropertyName = "SecurityLevel")]
			public string SecurityLevel
			{
				get
				{
					return securityLevel;
				}
				set	
				{
					securityLevel = value;
				}
			}

			[JsonProperty(PropertyName = "DataLength")]
			public long? DataLength
			{
				get
				{
					return dataLength;
				}
				set	
				{
					dataLength = value;
				}
			}

			[JsonProperty(PropertyName = "DataScale")]
			public int? DataScale
			{
				get
				{
					return dataScale;
				}
				set	
				{
					dataScale = value;
				}
			}

			[JsonProperty(PropertyName = "DataPrecision")]
			public int? DataPrecision
			{
				get
				{
					return dataPrecision;
				}
				set	
				{
					dataPrecision = value;
				}
			}

			[JsonProperty(PropertyName = "Sensitive")]
			public bool? Sensitive
			{
				get
				{
					return sensitive;
				}
				set	
				{
					sensitive = value;
				}
			}

			[JsonProperty(PropertyName = "Nullable")]
			public bool? Nullable
			{
				get
				{
					return nullable;
				}
				set	
				{
					nullable = value;
				}
			}
		}
	}
}
