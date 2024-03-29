// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 100 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sysdescr_100 = 100;
	/// <summary>PID: 100 | Type: read</summary>
	public const int sysdescr = 100;
	/// <summary>PID: 101 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sysuptime_101 = 101;
	/// <summary>PID: 101 | Type: read</summary>
	public const int sysuptime = 101;
	/// <summary>PID: 102 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int syscontact_102 = 102;
	/// <summary>PID: 102 | Type: read</summary>
	public const int syscontact = 102;
	/// <summary>PID: 103 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int sysname_103 = 103;
	/// <summary>PID: 103 | Type: read</summary>
	public const int sysname = 103;
	/// <summary>PID: 104 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int syslocation_104 = 104;
	/// <summary>PID: 104 | Type: read</summary>
	public const int syslocation = 104;
	public class Write
	{
		/// <summary>PID: 202 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int syscontact_202 = 202;
		/// <summary>PID: 202 | Type: write</summary>
		public const int syscontact = 202;
		/// <summary>PID: 203 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int sysname_203 = 203;
		/// <summary>PID: 203 | Type: write</summary>
		public const int sysname = 203;
		/// <summary>PID: 204 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int syslocation_204 = 204;
		/// <summary>PID: 204 | Type: write</summary>
		public const int syslocation = 204;
	}
}
public class WriteParameters
{
	/// <summary>PID: 202  | Type: write</summary>
	public System.Object Syscontact {get { return Protocol.GetParameter(202); }set { Protocol.SetParameter(202, value); }}
	/// <summary>PID: 203  | Type: write</summary>
	public System.Object Sysname {get { return Protocol.GetParameter(203); }set { Protocol.SetParameter(203, value); }}
	/// <summary>PID: 204  | Type: write</summary>
	public System.Object Syslocation {get { return Protocol.GetParameter(204); }set { Protocol.SetParameter(204, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	object Sysdescr_100 { get; set; }
	object Sysdescr { get; set; }
	object Sysuptime_101 { get; set; }
	object Sysuptime { get; set; }
	object Syscontact_102 { get; set; }
	object Syscontact { get; set; }
	object Sysname_103 { get; set; }
	object Sysname { get; set; }
	object Syslocation_104 { get; set; }
	object Syslocation { get; set; }
	object Syscontact_202 { get; set; }
	object Sysname_203 { get; set; }
	object Syslocation_204 { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 100  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Sysdescr_100 {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 100  | Type: read</summary>
	public System.Object Sysdescr {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 101  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Sysuptime_101 {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 101  | Type: read</summary>
	public System.Object Sysuptime {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Syscontact_102 {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 102  | Type: read</summary>
	public System.Object Syscontact {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 103  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Sysname_103 {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 103  | Type: read</summary>
	public System.Object Sysname {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 104  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Syslocation_104 {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 104  | Type: read</summary>
	public System.Object Syslocation {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 202  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Syscontact_202 {get { return GetParameter(202); }set { SetParameter(202, value); }}
	/// <summary>PID: 203  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Sysname_203 {get { return GetParameter(203); }set { SetParameter(203, value); }}
	/// <summary>PID: 204  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Syslocation_204 {get { return GetParameter(204); }set { SetParameter(204, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		Write = new WriteParameters(this);
	}
}
}
