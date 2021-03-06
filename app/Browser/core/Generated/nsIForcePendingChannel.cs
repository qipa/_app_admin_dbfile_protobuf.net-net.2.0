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
// Generated by IDLImporter from file nsIForcePendingChannel.idl
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
    /// nsIForcePending interface exposes a function that enables overwriting of the normal
    /// behavior for the channel's IsPending(), forcing 'true' to be returned.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("225ab092-1554-423a-9492-606f6db3b4fb")]
	public interface nsIForcePendingChannel
	{
		
		/// <summary>
        /// forcePending(true) overrides the normal behavior for the
        /// channel's IsPending(), forcing 'true' to be returned. A call to
        /// forcePending(false) reverts IsPending() back to normal behavior.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForcePending([MarshalAs(UnmanagedType.U1)] bool aForcePending);
	}
}
