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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class StartPredictiveCallResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private List<string> _params;

		private StartPredictiveCall_Data data;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<string> _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
			}
		}

		public StartPredictiveCall_Data Data
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

		public class StartPredictiveCall_Data
		{

			private StartPredictiveCall_CallContext callContext;

			private StartPredictiveCall_UserContext userContext;

			public StartPredictiveCall_CallContext CallContext
			{
				get
				{
					return callContext;
				}
				set	
				{
					callContext = value;
				}
			}

			public StartPredictiveCall_UserContext UserContext
			{
				get
				{
					return userContext;
				}
				set	
				{
					userContext = value;
				}
			}

			public class StartPredictiveCall_CallContext
			{

				private string callType;

				private string instanceId;

				private string jobId;

				private List<StartPredictiveCall_ChannelContext> channelContexts;

				public string CallType
				{
					get
					{
						return callType;
					}
					set	
					{
						callType = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public List<StartPredictiveCall_ChannelContext> ChannelContexts
				{
					get
					{
						return channelContexts;
					}
					set	
					{
						channelContexts = value;
					}
				}

				public class StartPredictiveCall_ChannelContext
				{

					private string releaseInitiator;

					private string channelState;

					private string destination;

					private string userId;

					private string channelFlags;

					private long? timestamp;

					private string associatedData;

					private string releaseReason;

					private string callType;

					private string jobId;

					private string channelId;

					private string originator;

					private string userExtension;

					public string ReleaseInitiator
					{
						get
						{
							return releaseInitiator;
						}
						set	
						{
							releaseInitiator = value;
						}
					}

					public string ChannelState
					{
						get
						{
							return channelState;
						}
						set	
						{
							channelState = value;
						}
					}

					public string Destination
					{
						get
						{
							return destination;
						}
						set	
						{
							destination = value;
						}
					}

					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public string ChannelFlags
					{
						get
						{
							return channelFlags;
						}
						set	
						{
							channelFlags = value;
						}
					}

					public long? Timestamp
					{
						get
						{
							return timestamp;
						}
						set	
						{
							timestamp = value;
						}
					}

					public string AssociatedData
					{
						get
						{
							return associatedData;
						}
						set	
						{
							associatedData = value;
						}
					}

					public string ReleaseReason
					{
						get
						{
							return releaseReason;
						}
						set	
						{
							releaseReason = value;
						}
					}

					public string CallType
					{
						get
						{
							return callType;
						}
						set	
						{
							callType = value;
						}
					}

					public string JobId
					{
						get
						{
							return jobId;
						}
						set	
						{
							jobId = value;
						}
					}

					public string ChannelId
					{
						get
						{
							return channelId;
						}
						set	
						{
							channelId = value;
						}
					}

					public string Originator
					{
						get
						{
							return originator;
						}
						set	
						{
							originator = value;
						}
					}

					public string UserExtension
					{
						get
						{
							return userExtension;
						}
						set	
						{
							userExtension = value;
						}
					}
				}
			}

			public class StartPredictiveCall_UserContext
			{

				private string extension;

				private long? heartbeat;

				private string workMode;

				private string deviceId;

				private string userId;

				private long? reserved;

				private string breakCode;

				private string instanceId;

				private bool? outboundScenario;

				private string deviceState;

				private string mobile;

				private string jobId;

				private string userState;

				private List<string> signedSkillGroupIdList;

				public string Extension
				{
					get
					{
						return extension;
					}
					set	
					{
						extension = value;
					}
				}

				public long? Heartbeat
				{
					get
					{
						return heartbeat;
					}
					set	
					{
						heartbeat = value;
					}
				}

				public string WorkMode
				{
					get
					{
						return workMode;
					}
					set	
					{
						workMode = value;
					}
				}

				public string DeviceId
				{
					get
					{
						return deviceId;
					}
					set	
					{
						deviceId = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public long? Reserved
				{
					get
					{
						return reserved;
					}
					set	
					{
						reserved = value;
					}
				}

				public string BreakCode
				{
					get
					{
						return breakCode;
					}
					set	
					{
						breakCode = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public bool? OutboundScenario
				{
					get
					{
						return outboundScenario;
					}
					set	
					{
						outboundScenario = value;
					}
				}

				public string DeviceState
				{
					get
					{
						return deviceState;
					}
					set	
					{
						deviceState = value;
					}
				}

				public string Mobile
				{
					get
					{
						return mobile;
					}
					set	
					{
						mobile = value;
					}
				}

				public string JobId
				{
					get
					{
						return jobId;
					}
					set	
					{
						jobId = value;
					}
				}

				public string UserState
				{
					get
					{
						return userState;
					}
					set	
					{
						userState = value;
					}
				}

				public List<string> SignedSkillGroupIdList
				{
					get
					{
						return signedSkillGroupIdList;
					}
					set	
					{
						signedSkillGroupIdList = value;
					}
				}
			}
		}
	}
}
