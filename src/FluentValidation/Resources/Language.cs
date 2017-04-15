#region License
// Copyright (c) Jeremy Skinner (http://www.jeremyskinner.co.uk)
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
// The latest version of this file can be found at http://fluentvalidation.codeplex.com
#endregion
namespace FluentValidation.Resources {
	using System.Collections.Generic;

	/// <summary>
	/// Base class for lanaguages
	/// </summary>
	public abstract class Language {

		/// <summary>
		/// Name of language (culture code)
		/// </summary>
		public abstract string Name { get; }
		/// <summary>
		/// Localized strings held by this language
		/// </summary>
		public Dictionary<string, string> Translations { get; } = new Dictionary<string, string>();

		/// <summary>
		/// Adds a translation
		/// </summary>
		/// <param name="key"></param>
		/// <param name="message"></param>
		public void Translate(string key, string message) {
			Translations[key] = message;
		}
		
		/// <summary>
		/// Adds a translation for a type
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="message"></param>
		public void Translate<T>(string message) {
			Translations[typeof(T).Name] = message;
		}
	}
}