#region Copyright & License
//
// Copyright 2001-2004 The Apache Software Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;

namespace log4net.Core
{
	/// <summary>
	/// Appenders may delegate their error handling to an <see cref="IErrorHandler" />.
	/// </summary>
	/// <remarks>
	/// Error handling is a particularly tedious to get right because by
	/// definition errors are hard to predict and to reproduce. 
	/// </remarks>
	/// <author>Nicko Cadell</author>
	/// <author>Gert Driesen</author>
	public interface IErrorHandler
	{
		/// <summary>
		/// Handles the error and information about the error condition is passed as 
		/// a parameter.
		/// </summary>
		/// <param name="message">The message associated with the error.</param>
		/// <param name="e">The <see cref="Exception" /> that was thrown when the error occurred.</param>
		/// <param name="errorCode">The error code associated with the error.</param>
		void Error(string message, Exception e, ErrorCode errorCode);

		/// <summary>
		/// Prints the error message passed as a parameter.
		/// </summary>
		/// <param name="message">The message associated with the error.</param>
		/// <param name="e">The <see cref="Exception" /> that was thrown when the error occurred.</param>
		void Error(string message, Exception e);

		/// <summary>
		/// Prints the error message passed as a parameter.
		/// </summary>
		/// <param name="message">The message associated with the error.</param>
		void Error(string message);
	}
}
