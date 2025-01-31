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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetFileResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string errorMessage;

		private string requestId;

		private string errorCode;

		private bool? success;

		private GetFile_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

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

		public GetFile_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetFile_Data
		{

			private GetFile_File file;

			private GetFile_NodeConfiguration nodeConfiguration;

			public GetFile_File File
			{
				get
				{
					return file;
				}
				set	
				{
					file = value;
				}
			}

			public GetFile_NodeConfiguration NodeConfiguration
			{
				get
				{
					return nodeConfiguration;
				}
				set	
				{
					nodeConfiguration = value;
				}
			}

			public class GetFile_File
			{

				private int? commitStatus;

				private bool? autoParsing;

				private string owner;

				private long? createTime;

				private int? fileType;

				private int? currentVersion;

				private long? bizId;

				private string lastEditUser;

				private string fileName;

				private string connectionName;

				private string useType;

				private string fileFolderId;

				private long? parentId;

				private string createUser;

				private bool? isMaxCompute;

				private long? businessId;

				private string fileDescription;

				private string deletedStatus;

				private long? lastEditTime;

				private string content;

				private long? nodeId;

				public int? CommitStatus
				{
					get
					{
						return commitStatus;
					}
					set	
					{
						commitStatus = value;
					}
				}

				public bool? AutoParsing
				{
					get
					{
						return autoParsing;
					}
					set	
					{
						autoParsing = value;
					}
				}

				public string Owner
				{
					get
					{
						return owner;
					}
					set	
					{
						owner = value;
					}
				}

				public long? CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public int? FileType
				{
					get
					{
						return fileType;
					}
					set	
					{
						fileType = value;
					}
				}

				public int? CurrentVersion
				{
					get
					{
						return currentVersion;
					}
					set	
					{
						currentVersion = value;
					}
				}

				public long? BizId
				{
					get
					{
						return bizId;
					}
					set	
					{
						bizId = value;
					}
				}

				public string LastEditUser
				{
					get
					{
						return lastEditUser;
					}
					set	
					{
						lastEditUser = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}

				public string ConnectionName
				{
					get
					{
						return connectionName;
					}
					set	
					{
						connectionName = value;
					}
				}

				public string UseType
				{
					get
					{
						return useType;
					}
					set	
					{
						useType = value;
					}
				}

				public string FileFolderId
				{
					get
					{
						return fileFolderId;
					}
					set	
					{
						fileFolderId = value;
					}
				}

				public long? ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public string CreateUser
				{
					get
					{
						return createUser;
					}
					set	
					{
						createUser = value;
					}
				}

				public bool? IsMaxCompute
				{
					get
					{
						return isMaxCompute;
					}
					set	
					{
						isMaxCompute = value;
					}
				}

				public long? BusinessId
				{
					get
					{
						return businessId;
					}
					set	
					{
						businessId = value;
					}
				}

				public string FileDescription
				{
					get
					{
						return fileDescription;
					}
					set	
					{
						fileDescription = value;
					}
				}

				public string DeletedStatus
				{
					get
					{
						return deletedStatus;
					}
					set	
					{
						deletedStatus = value;
					}
				}

				public long? LastEditTime
				{
					get
					{
						return lastEditTime;
					}
					set	
					{
						lastEditTime = value;
					}
				}

				public string Content
				{
					get
					{
						return content;
					}
					set	
					{
						content = value;
					}
				}

				public long? NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}
			}

			public class GetFile_NodeConfiguration
			{

				private string rerunMode;

				private string schedulerType;

				private bool? stop;

				private string paraValue;

				private long? startEffectDate;

				private long? endEffectDate;

				private string cycleType;

				private string dependentNodeIdList;

				private long? resourceGroupId;

				private string dependentType;

				private int? autoRerunTimes;

				private int? autoRerunIntervalMillis;

				private string cronExpress;

				private List<GetFile_NodeInputOutput> inputList;

				private List<GetFile_NodeInputOutput1> outputList;

				public string RerunMode
				{
					get
					{
						return rerunMode;
					}
					set	
					{
						rerunMode = value;
					}
				}

				public string SchedulerType
				{
					get
					{
						return schedulerType;
					}
					set	
					{
						schedulerType = value;
					}
				}

				public bool? Stop
				{
					get
					{
						return stop;
					}
					set	
					{
						stop = value;
					}
				}

				public string ParaValue
				{
					get
					{
						return paraValue;
					}
					set	
					{
						paraValue = value;
					}
				}

				public long? StartEffectDate
				{
					get
					{
						return startEffectDate;
					}
					set	
					{
						startEffectDate = value;
					}
				}

				public long? EndEffectDate
				{
					get
					{
						return endEffectDate;
					}
					set	
					{
						endEffectDate = value;
					}
				}

				public string CycleType
				{
					get
					{
						return cycleType;
					}
					set	
					{
						cycleType = value;
					}
				}

				public string DependentNodeIdList
				{
					get
					{
						return dependentNodeIdList;
					}
					set	
					{
						dependentNodeIdList = value;
					}
				}

				public long? ResourceGroupId
				{
					get
					{
						return resourceGroupId;
					}
					set	
					{
						resourceGroupId = value;
					}
				}

				public string DependentType
				{
					get
					{
						return dependentType;
					}
					set	
					{
						dependentType = value;
					}
				}

				public int? AutoRerunTimes
				{
					get
					{
						return autoRerunTimes;
					}
					set	
					{
						autoRerunTimes = value;
					}
				}

				public int? AutoRerunIntervalMillis
				{
					get
					{
						return autoRerunIntervalMillis;
					}
					set	
					{
						autoRerunIntervalMillis = value;
					}
				}

				public string CronExpress
				{
					get
					{
						return cronExpress;
					}
					set	
					{
						cronExpress = value;
					}
				}

				public List<GetFile_NodeInputOutput> InputList
				{
					get
					{
						return inputList;
					}
					set	
					{
						inputList = value;
					}
				}

				public List<GetFile_NodeInputOutput1> OutputList
				{
					get
					{
						return outputList;
					}
					set	
					{
						outputList = value;
					}
				}

				public class GetFile_NodeInputOutput
				{

					private string input;

					private string parseType;

					public string Input
					{
						get
						{
							return input;
						}
						set	
						{
							input = value;
						}
					}

					public string ParseType
					{
						get
						{
							return parseType;
						}
						set	
						{
							parseType = value;
						}
					}
				}

				public class GetFile_NodeInputOutput1
				{

					private string refTableName;

					private string output;

					public string RefTableName
					{
						get
						{
							return refTableName;
						}
						set	
						{
							refTableName = value;
						}
					}

					public string Output
					{
						get
						{
							return output;
						}
						set	
						{
							output = value;
						}
					}
				}
			}
		}
	}
}
