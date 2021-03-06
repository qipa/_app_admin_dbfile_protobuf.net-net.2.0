// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file mozIGeckoMediaPluginService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a9b826da-725a-4b81-814f-b715445188f2")]
	public interface mozIGeckoMediaPluginService
	{
		
		/// <summary>
        /// The GMP thread. Callable from any thread.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIThread GetThreadAttribute();
		
		/// <summary>
        /// Get a plugin that supports the specified tags.
        /// Callable on any thread
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasPluginForAPI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase api, TagArray tags);
		
		/// <summary>
        /// Get a video decoder that supports the specified tags.
        /// The array of tags should at least contain a codec tag, and optionally
        /// other tags such as for EME keysystem.
        /// Callable only on GMP thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		GMPVideoDecoderProxy GetGMPVideoDecoder(TagArray tags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, ref GMPVideoHost outVideoHost);
		
		/// <summary>
        /// Get a video encoder that supports the specified tags.
        /// The array of tags should at least contain a codec tag, and optionally
        /// other tags.
        /// Callable only on GMP thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		GMPVideoEncoderProxy GetGMPVideoEncoder(TagArray tags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase origin, ref GMPVideoHost outVideoHost);
		
		/// <summary>
        /// Add a directory to scan for gecko media plugins.
        /// @note Main-thread API.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPluginDirectory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase directory);
		
		/// <summary>
        /// Remove a directory for gecko media plugins.
        /// @note Main-thread API.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePluginDirectory([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase directory);
	}
}
