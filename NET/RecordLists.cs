using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssMusicDBExternalData {

	/// <summary>
	/// RecordList type <code>RLt_MUEventRecordList</code> that represents a record list of
	///  <code>t_MUEvent</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUEventRecordList: GenericRecordList<RCt_MUEventRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUEventRecord GetElementDefaultValue() {
			return new RCt_MUEventRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUEventRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUEventRecordList recordlist, Func<RCt_MUEventRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUEventRecordList ToList<T>(T[] array, Func <T, RCt_MUEventRecord> converter) {
			RLt_MUEventRecordList result = new RLt_MUEventRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUEventRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUEventRecord> converter) {
			RLt_MUEventRecordList result = new RLt_MUEventRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUEventRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUEventRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUEventRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUEventRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(10, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUEventRecord> NewList() {
			return new RLt_MUEventRecordList();
		}


	} // RLt_MUEventRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUAlbumSongRecordList</code> that represents a record list of
	///  <code>t_MUAlbumSong</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUAlbumSongRecordList: GenericRecordList<RCt_MUAlbumSongRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUAlbumSongRecord GetElementDefaultValue() {
			return new RCt_MUAlbumSongRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUAlbumSongRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUAlbumSongRecordList recordlist, Func<RCt_MUAlbumSongRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUAlbumSongRecordList ToList<T>(T[] array, Func <T, RCt_MUAlbumSongRecord> converter) {
			RLt_MUAlbumSongRecordList result = new RLt_MUAlbumSongRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUAlbumSongRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUAlbumSongRecord> converter) {
			RLt_MUAlbumSongRecordList result = new RLt_MUAlbumSongRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUAlbumSongRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumSongRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumSongRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUAlbumSongRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUAlbumSongRecord> NewList() {
			return new RLt_MUAlbumSongRecordList();
		}


	} // RLt_MUAlbumSongRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUSongRecordList</code> that represents a record list of
	///  <code>t_MUSong</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUSongRecordList: GenericRecordList<RCt_MUSongRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUSongRecord GetElementDefaultValue() {
			return new RCt_MUSongRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUSongRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUSongRecordList recordlist, Func<RCt_MUSongRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUSongRecordList ToList<T>(T[] array, Func <T, RCt_MUSongRecord> converter) {
			RLt_MUSongRecordList result = new RLt_MUSongRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUSongRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUSongRecord> converter) {
			RLt_MUSongRecordList result = new RLt_MUSongRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUSongRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUSongRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUSongRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUSongRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(7, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUSongRecord> NewList() {
			return new RLt_MUSongRecordList();
		}


	} // RLt_MUSongRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistMusicStyleRecordList</code> that represents a record list of
	///  <code>t_MUArtistMusicStyle</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistMusicStyleRecordList: GenericRecordList<RCt_MUArtistMusicStyleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistMusicStyleRecord GetElementDefaultValue() {
			return new RCt_MUArtistMusicStyleRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistMusicStyleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistMusicStyleRecordList recordlist, Func<RCt_MUArtistMusicStyleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistMusicStyleRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistMusicStyleRecord> converter) {
			RLt_MUArtistMusicStyleRecordList result = new RLt_MUArtistMusicStyleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistMusicStyleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistMusicStyleRecord> converter) {
			RLt_MUArtistMusicStyleRecordList result = new RLt_MUArtistMusicStyleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistMusicStyleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistMusicStyleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistMusicStyleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistMusicStyleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistMusicStyleRecord> NewList() {
			return new RLt_MUArtistMusicStyleRecordList();
		}


	} // RLt_MUArtistMusicStyleRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDMusicStyleRecordList</code> that represents a record list of
	///  <code>t_MDMusicStyle</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDMusicStyleRecordList: GenericRecordList<RCt_MDMusicStyleRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDMusicStyleRecord GetElementDefaultValue() {
			return new RCt_MDMusicStyleRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDMusicStyleRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDMusicStyleRecordList recordlist, Func<RCt_MDMusicStyleRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDMusicStyleRecordList ToList<T>(T[] array, Func <T, RCt_MDMusicStyleRecord> converter) {
			RLt_MDMusicStyleRecordList result = new RLt_MDMusicStyleRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDMusicStyleRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDMusicStyleRecord> converter) {
			RLt_MDMusicStyleRecordList result = new RLt_MDMusicStyleRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDMusicStyleRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMusicStyleRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMusicStyleRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDMusicStyleRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDMusicStyleRecord> NewList() {
			return new RLt_MDMusicStyleRecordList();
		}


	} // RLt_MDMusicStyleRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDCountryRecordList</code> that represents a record list of
	///  <code>t_MDCountry</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDCountryRecordList: GenericRecordList<RCt_MDCountryRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDCountryRecord GetElementDefaultValue() {
			return new RCt_MDCountryRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDCountryRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDCountryRecordList recordlist, Func<RCt_MDCountryRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDCountryRecordList ToList<T>(T[] array, Func <T, RCt_MDCountryRecord> converter) {
			RLt_MDCountryRecordList result = new RLt_MDCountryRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDCountryRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDCountryRecord> converter) {
			RLt_MDCountryRecordList result = new RLt_MDCountryRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDCountryRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDCountryRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDCountryRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDCountryRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDCountryRecord> NewList() {
			return new RLt_MDCountryRecordList();
		}


	} // RLt_MDCountryRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDEventRecordList</code> that represents a record list of
	///  <code>t_MDEvent</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDEventRecordList: GenericRecordList<RCt_MDEventRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDEventRecord GetElementDefaultValue() {
			return new RCt_MDEventRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDEventRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDEventRecordList recordlist, Func<RCt_MDEventRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDEventRecordList ToList<T>(T[] array, Func <T, RCt_MDEventRecord> converter) {
			RLt_MDEventRecordList result = new RLt_MDEventRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDEventRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDEventRecord> converter) {
			RLt_MDEventRecordList result = new RLt_MDEventRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDEventRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDEventRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDEventRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDEventRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDEventRecord> NewList() {
			return new RLt_MDEventRecordList();
		}


	} // RLt_MDEventRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUAlbumRecordList</code> that represents a record list of
	///  <code>t_MUAlbum</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUAlbumRecordList: GenericRecordList<RCt_MUAlbumRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUAlbumRecord GetElementDefaultValue() {
			return new RCt_MUAlbumRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUAlbumRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUAlbumRecordList recordlist, Func<RCt_MUAlbumRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUAlbumRecordList ToList<T>(T[] array, Func <T, RCt_MUAlbumRecord> converter) {
			RLt_MUAlbumRecordList result = new RLt_MUAlbumRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUAlbumRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUAlbumRecord> converter) {
			RLt_MUAlbumRecordList result = new RLt_MUAlbumRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUAlbumRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUAlbumRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(7, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUAlbumRecord> NewList() {
			return new RLt_MUAlbumRecordList();
		}


	} // RLt_MUAlbumRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistRecordList</code> that represents a record list of
	///  <code>t_MUArtist</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistRecordList: GenericRecordList<RCt_MUArtistRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistRecord GetElementDefaultValue() {
			return new RCt_MUArtistRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistRecordList recordlist, Func<RCt_MUArtistRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistRecord> converter) {
			RLt_MUArtistRecordList result = new RLt_MUArtistRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistRecord> converter) {
			RLt_MUArtistRecordList result = new RLt_MUArtistRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistRecord> NewList() {
			return new RLt_MUArtistRecordList();
		}


	} // RLt_MUArtistRecordList

	/// <summary>
	/// RecordList type <code>RLt_VNVenueRecordList</code> that represents a record list of
	///  <code>t_VNVenue</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_VNVenueRecordList: GenericRecordList<RCt_VNVenueRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_VNVenueRecord GetElementDefaultValue() {
			return new RCt_VNVenueRecord("");
		}

		public T[] ToArray<T>(Func<RCt_VNVenueRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_VNVenueRecordList recordlist, Func<RCt_VNVenueRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_VNVenueRecordList ToList<T>(T[] array, Func <T, RCt_VNVenueRecord> converter) {
			RLt_VNVenueRecordList result = new RLt_VNVenueRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_VNVenueRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_VNVenueRecord> converter) {
			RLt_VNVenueRecordList result = new RLt_VNVenueRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_VNVenueRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_VNVenueRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_VNVenueRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_VNVenueRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(11, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_VNVenueRecord> NewList() {
			return new RLt_VNVenueRecordList();
		}


	} // RLt_VNVenueRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDDataPointRecordList</code> that represents a record list of
	///  <code>t_MDDataPoint</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDDataPointRecordList: GenericRecordList<RCt_MDDataPointRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDDataPointRecord GetElementDefaultValue() {
			return new RCt_MDDataPointRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDDataPointRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDDataPointRecordList recordlist, Func<RCt_MDDataPointRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDDataPointRecordList ToList<T>(T[] array, Func <T, RCt_MDDataPointRecord> converter) {
			RLt_MDDataPointRecordList result = new RLt_MDDataPointRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDDataPointRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDDataPointRecord> converter) {
			RLt_MDDataPointRecordList result = new RLt_MDDataPointRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDDataPointRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDDataPointRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDDataPointRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDDataPointRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDDataPointRecord> NewList() {
			return new RLt_MDDataPointRecordList();
		}


	} // RLt_MDDataPointRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistSocialMediaRecordList</code> that represents a record list of
	///  <code>t_MUArtistSocialMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistSocialMediaRecordList: GenericRecordList<RCt_MUArtistSocialMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistSocialMediaRecord GetElementDefaultValue() {
			return new RCt_MUArtistSocialMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistSocialMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistSocialMediaRecordList recordlist, Func<RCt_MUArtistSocialMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistSocialMediaRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistSocialMediaRecord> converter) {
			RLt_MUArtistSocialMediaRecordList result = new RLt_MUArtistSocialMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistSocialMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistSocialMediaRecord> converter) {
			RLt_MUArtistSocialMediaRecordList result = new RLt_MUArtistSocialMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistSocialMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistSocialMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistSocialMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistSocialMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistSocialMediaRecord> NewList() {
			return new RLt_MUArtistSocialMediaRecordList();
		}


	} // RLt_MUArtistSocialMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDSocialMediaRecordList</code> that represents a record list of
	///  <code>t_MDSocialMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDSocialMediaRecordList: GenericRecordList<RCt_MDSocialMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDSocialMediaRecord GetElementDefaultValue() {
			return new RCt_MDSocialMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDSocialMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDSocialMediaRecordList recordlist, Func<RCt_MDSocialMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDSocialMediaRecordList ToList<T>(T[] array, Func <T, RCt_MDSocialMediaRecord> converter) {
			RLt_MDSocialMediaRecordList result = new RLt_MDSocialMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDSocialMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDSocialMediaRecord> converter) {
			RLt_MDSocialMediaRecordList result = new RLt_MDSocialMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDSocialMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDSocialMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDSocialMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDSocialMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDSocialMediaRecord> NewList() {
			return new RLt_MDSocialMediaRecordList();
		}


	} // RLt_MDSocialMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_SMArtistDataPointRecordList</code> that represents a record list of
	///  <code>t_SMArtistDataPoint</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_SMArtistDataPointRecordList: GenericRecordList<RCt_SMArtistDataPointRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_SMArtistDataPointRecord GetElementDefaultValue() {
			return new RCt_SMArtistDataPointRecord("");
		}

		public T[] ToArray<T>(Func<RCt_SMArtistDataPointRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_SMArtistDataPointRecordList recordlist, Func<RCt_SMArtistDataPointRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_SMArtistDataPointRecordList ToList<T>(T[] array, Func <T, RCt_SMArtistDataPointRecord> converter) {
			RLt_SMArtistDataPointRecordList result = new RLt_SMArtistDataPointRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_SMArtistDataPointRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_SMArtistDataPointRecord> converter) {
			RLt_SMArtistDataPointRecordList result = new RLt_SMArtistDataPointRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_SMArtistDataPointRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_SMArtistDataPointRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_SMArtistDataPointRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_SMArtistDataPointRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(9, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_SMArtistDataPointRecord> NewList() {
			return new RLt_SMArtistDataPointRecordList();
		}


	} // RLt_SMArtistDataPointRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistCorrelationRecordList</code> that represents a record list of
	///  <code>t_MUArtistCorrelation</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistCorrelationRecordList: GenericRecordList<RCt_MUArtistCorrelationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistCorrelationRecord GetElementDefaultValue() {
			return new RCt_MUArtistCorrelationRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistCorrelationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistCorrelationRecordList recordlist, Func<RCt_MUArtistCorrelationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistCorrelationRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistCorrelationRecord> converter) {
			RLt_MUArtistCorrelationRecordList result = new RLt_MUArtistCorrelationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistCorrelationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistCorrelationRecord> converter) {
			RLt_MUArtistCorrelationRecordList result = new RLt_MUArtistCorrelationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistCorrelationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistCorrelationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistCorrelationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistCorrelationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(6, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistCorrelationRecord> NewList() {
			return new RLt_MUArtistCorrelationRecordList();
		}


	} // RLt_MUArtistCorrelationRecordList

	/// <summary>
	/// RecordList type <code>RLt_MGPromoterRecordList</code> that represents a record list of
	///  <code>t_MGPromoter</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MGPromoterRecordList: GenericRecordList<RCt_MGPromoterRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MGPromoterRecord GetElementDefaultValue() {
			return new RCt_MGPromoterRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MGPromoterRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MGPromoterRecordList recordlist, Func<RCt_MGPromoterRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MGPromoterRecordList ToList<T>(T[] array, Func <T, RCt_MGPromoterRecord> converter) {
			RLt_MGPromoterRecordList result = new RLt_MGPromoterRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MGPromoterRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MGPromoterRecord> converter) {
			RLt_MGPromoterRecordList result = new RLt_MGPromoterRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MGPromoterRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGPromoterRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGPromoterRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MGPromoterRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(6, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MGPromoterRecord> NewList() {
			return new RLt_MGPromoterRecordList();
		}


	} // RLt_MGPromoterRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDContactRecordList</code> that represents a record list of
	///  <code>t_MDContact</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDContactRecordList: GenericRecordList<RCt_MDContactRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDContactRecord GetElementDefaultValue() {
			return new RCt_MDContactRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDContactRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDContactRecordList recordlist, Func<RCt_MDContactRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDContactRecordList ToList<T>(T[] array, Func <T, RCt_MDContactRecord> converter) {
			RLt_MDContactRecordList result = new RLt_MDContactRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDContactRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDContactRecord> converter) {
			RLt_MDContactRecordList result = new RLt_MDContactRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDContactRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDContactRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDContactRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDContactRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDContactRecord> NewList() {
			return new RLt_MDContactRecordList();
		}


	} // RLt_MDContactRecordList

	/// <summary>
	/// RecordList type <code>RLt_CTContactRecordList</code> that represents a record list of
	///  <code>t_CTContact</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_CTContactRecordList: GenericRecordList<RCt_CTContactRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_CTContactRecord GetElementDefaultValue() {
			return new RCt_CTContactRecord("");
		}

		public T[] ToArray<T>(Func<RCt_CTContactRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_CTContactRecordList recordlist, Func<RCt_CTContactRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_CTContactRecordList ToList<T>(T[] array, Func <T, RCt_CTContactRecord> converter) {
			RLt_CTContactRecordList result = new RLt_CTContactRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_CTContactRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_CTContactRecord> converter) {
			RLt_CTContactRecordList result = new RLt_CTContactRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_CTContactRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_CTContactRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_CTContactRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_CTContactRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(8, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_CTContactRecord> NewList() {
			return new RLt_CTContactRecordList();
		}


	} // RLt_CTContactRecordList

	/// <summary>
	/// RecordList type <code>RLt_MGPromoterContactRecordList</code> that represents a record list of
	///  <code>t_MGPromoterContact</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MGPromoterContactRecordList: GenericRecordList<RCt_MGPromoterContactRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MGPromoterContactRecord GetElementDefaultValue() {
			return new RCt_MGPromoterContactRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MGPromoterContactRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MGPromoterContactRecordList recordlist, Func<RCt_MGPromoterContactRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MGPromoterContactRecordList ToList<T>(T[] array, Func <T, RCt_MGPromoterContactRecord> converter) {
			RLt_MGPromoterContactRecordList result = new RLt_MGPromoterContactRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MGPromoterContactRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MGPromoterContactRecord> converter) {
			RLt_MGPromoterContactRecordList result = new RLt_MGPromoterContactRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MGPromoterContactRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGPromoterContactRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGPromoterContactRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MGPromoterContactRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MGPromoterContactRecord> NewList() {
			return new RLt_MGPromoterContactRecordList();
		}


	} // RLt_MGPromoterContactRecordList

	/// <summary>
	/// RecordList type <code>RLt_MGFestivalContactRecordList</code> that represents a record list of
	///  <code>t_MGFestivalContact</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MGFestivalContactRecordList: GenericRecordList<RCt_MGFestivalContactRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MGFestivalContactRecord GetElementDefaultValue() {
			return new RCt_MGFestivalContactRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MGFestivalContactRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MGFestivalContactRecordList recordlist, Func<RCt_MGFestivalContactRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MGFestivalContactRecordList ToList<T>(T[] array, Func <T, RCt_MGFestivalContactRecord> converter) {
			RLt_MGFestivalContactRecordList result = new RLt_MGFestivalContactRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MGFestivalContactRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MGFestivalContactRecord> converter) {
			RLt_MGFestivalContactRecordList result = new RLt_MGFestivalContactRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MGFestivalContactRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGFestivalContactRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGFestivalContactRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MGFestivalContactRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MGFestivalContactRecord> NewList() {
			return new RLt_MGFestivalContactRecordList();
		}


	} // RLt_MGFestivalContactRecordList

	/// <summary>
	/// RecordList type <code>RLt_MGFestivalRecordList</code> that represents a record list of
	///  <code>t_MGFestival</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MGFestivalRecordList: GenericRecordList<RCt_MGFestivalRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MGFestivalRecord GetElementDefaultValue() {
			return new RCt_MGFestivalRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MGFestivalRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MGFestivalRecordList recordlist, Func<RCt_MGFestivalRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MGFestivalRecordList ToList<T>(T[] array, Func <T, RCt_MGFestivalRecord> converter) {
			RLt_MGFestivalRecordList result = new RLt_MGFestivalRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MGFestivalRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MGFestivalRecord> converter) {
			RLt_MGFestivalRecordList result = new RLt_MGFestivalRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MGFestivalRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGFestivalRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MGFestivalRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MGFestivalRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(6, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MGFestivalRecord> NewList() {
			return new RLt_MGFestivalRecordList();
		}


	} // RLt_MGFestivalRecordList

	/// <summary>
	/// RecordList type <code>RLt_VNVenueContactRecordList</code> that represents a record list of
	///  <code>t_VNVenueContact</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_VNVenueContactRecordList: GenericRecordList<RCt_VNVenueContactRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_VNVenueContactRecord GetElementDefaultValue() {
			return new RCt_VNVenueContactRecord("");
		}

		public T[] ToArray<T>(Func<RCt_VNVenueContactRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_VNVenueContactRecordList recordlist, Func<RCt_VNVenueContactRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_VNVenueContactRecordList ToList<T>(T[] array, Func <T, RCt_VNVenueContactRecord> converter) {
			RLt_VNVenueContactRecordList result = new RLt_VNVenueContactRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_VNVenueContactRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_VNVenueContactRecord> converter) {
			RLt_VNVenueContactRecordList result = new RLt_VNVenueContactRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_VNVenueContactRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_VNVenueContactRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_VNVenueContactRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_VNVenueContactRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_VNVenueContactRecord> NewList() {
			return new RLt_VNVenueContactRecordList();
		}


	} // RLt_VNVenueContactRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistDataSetRecordList</code> that represents a record list of
	///  <code>t_MUArtistDataSet</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistDataSetRecordList: GenericRecordList<RCt_MUArtistDataSetRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistDataSetRecord GetElementDefaultValue() {
			return new RCt_MUArtistDataSetRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistDataSetRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistDataSetRecordList recordlist, Func<RCt_MUArtistDataSetRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistDataSetRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistDataSetRecord> converter) {
			RLt_MUArtistDataSetRecordList result = new RLt_MUArtistDataSetRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistDataSetRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistDataSetRecord> converter) {
			RLt_MUArtistDataSetRecordList result = new RLt_MUArtistDataSetRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistDataSetRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistDataSetRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistDataSetRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistDataSetRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistDataSetRecord> NewList() {
			return new RLt_MUArtistDataSetRecordList();
		}


	} // RLt_MUArtistDataSetRecordList

	/// <summary>
	/// RecordList type <code>RLt_STDataSetRecordList</code> that represents a record list of
	///  <code>t_STDataSet</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_STDataSetRecordList: GenericRecordList<RCt_STDataSetRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_STDataSetRecord GetElementDefaultValue() {
			return new RCt_STDataSetRecord("");
		}

		public T[] ToArray<T>(Func<RCt_STDataSetRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_STDataSetRecordList recordlist, Func<RCt_STDataSetRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_STDataSetRecordList ToList<T>(T[] array, Func <T, RCt_STDataSetRecord> converter) {
			RLt_STDataSetRecordList result = new RLt_STDataSetRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_STDataSetRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_STDataSetRecord> converter) {
			RLt_STDataSetRecordList result = new RLt_STDataSetRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_STDataSetRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_STDataSetRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_STDataSetRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_STDataSetRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(6, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_STDataSetRecord> NewList() {
			return new RLt_STDataSetRecordList();
		}


	} // RLt_STDataSetRecordList

	/// <summary>
	/// RecordList type <code>RLt_STDataPointRecordList</code> that represents a record list of
	///  <code>t_STDataPoint</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_STDataPointRecordList: GenericRecordList<RCt_STDataPointRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_STDataPointRecord GetElementDefaultValue() {
			return new RCt_STDataPointRecord("");
		}

		public T[] ToArray<T>(Func<RCt_STDataPointRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_STDataPointRecordList recordlist, Func<RCt_STDataPointRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_STDataPointRecordList ToList<T>(T[] array, Func <T, RCt_STDataPointRecord> converter) {
			RLt_STDataPointRecordList result = new RLt_STDataPointRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_STDataPointRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_STDataPointRecord> converter) {
			RLt_STDataPointRecordList result = new RLt_STDataPointRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_STDataPointRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_STDataPointRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_STDataPointRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_STDataPointRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(9, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_STDataPointRecord> NewList() {
			return new RLt_STDataPointRecordList();
		}


	} // RLt_STDataPointRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDDataSetRecordList</code> that represents a record list of
	///  <code>t_MDDataSet</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDDataSetRecordList: GenericRecordList<RCt_MDDataSetRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDDataSetRecord GetElementDefaultValue() {
			return new RCt_MDDataSetRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDDataSetRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDDataSetRecordList recordlist, Func<RCt_MDDataSetRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDDataSetRecordList ToList<T>(T[] array, Func <T, RCt_MDDataSetRecord> converter) {
			RLt_MDDataSetRecordList result = new RLt_MDDataSetRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDDataSetRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDDataSetRecord> converter) {
			RLt_MDDataSetRecordList result = new RLt_MDDataSetRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDDataSetRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDDataSetRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDDataSetRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDDataSetRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDDataSetRecord> NewList() {
			return new RLt_MDDataSetRecordList();
		}


	} // RLt_MDDataSetRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistAlbumRecordList</code> that represents a record list of
	///  <code>t_MUArtistAlbum</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistAlbumRecordList: GenericRecordList<RCt_MUArtistAlbumRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistAlbumRecord GetElementDefaultValue() {
			return new RCt_MUArtistAlbumRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistAlbumRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistAlbumRecordList recordlist, Func<RCt_MUArtistAlbumRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistAlbumRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistAlbumRecord> converter) {
			RLt_MUArtistAlbumRecordList result = new RLt_MUArtistAlbumRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistAlbumRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistAlbumRecord> converter) {
			RLt_MUArtistAlbumRecordList result = new RLt_MUArtistAlbumRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistAlbumRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistAlbumRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistAlbumRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistAlbumRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistAlbumRecord> NewList() {
			return new RLt_MUArtistAlbumRecordList();
		}


	} // RLt_MUArtistAlbumRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDMediaRecordList</code> that represents a record list of
	///  <code>t_MDMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDMediaRecordList: GenericRecordList<RCt_MDMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDMediaRecord GetElementDefaultValue() {
			return new RCt_MDMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDMediaRecordList recordlist, Func<RCt_MDMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDMediaRecordList ToList<T>(T[] array, Func <T, RCt_MDMediaRecord> converter) {
			RLt_MDMediaRecordList result = new RLt_MDMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDMediaRecord> converter) {
			RLt_MDMediaRecordList result = new RLt_MDMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDMediaRecord> NewList() {
			return new RLt_MDMediaRecordList();
		}


	} // RLt_MDMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_MTMediaRecordList</code> that represents a record list of
	///  <code>t_MTMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MTMediaRecordList: GenericRecordList<RCt_MTMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MTMediaRecord GetElementDefaultValue() {
			return new RCt_MTMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MTMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MTMediaRecordList recordlist, Func<RCt_MTMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MTMediaRecordList ToList<T>(T[] array, Func <T, RCt_MTMediaRecord> converter) {
			RLt_MTMediaRecordList result = new RLt_MTMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MTMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MTMediaRecord> converter) {
			RLt_MTMediaRecordList result = new RLt_MTMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MTMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MTMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MTMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MTMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(7, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MTMediaRecord> NewList() {
			return new RLt_MTMediaRecordList();
		}


	} // RLt_MTMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistMediaRecordList</code> that represents a record list of
	///  <code>t_MUArtistMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistMediaRecordList: GenericRecordList<RCt_MUArtistMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistMediaRecord GetElementDefaultValue() {
			return new RCt_MUArtistMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistMediaRecordList recordlist, Func<RCt_MUArtistMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistMediaRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistMediaRecord> converter) {
			RLt_MUArtistMediaRecordList result = new RLt_MUArtistMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistMediaRecord> converter) {
			RLt_MUArtistMediaRecordList result = new RLt_MUArtistMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistMediaRecord> NewList() {
			return new RLt_MUArtistMediaRecordList();
		}


	} // RLt_MUArtistMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_MDMediaFileRecordList</code> that represents a record list of
	///  <code>t_MDMediaFile</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MDMediaFileRecordList: GenericRecordList<RCt_MDMediaFileRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MDMediaFileRecord GetElementDefaultValue() {
			return new RCt_MDMediaFileRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MDMediaFileRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MDMediaFileRecordList recordlist, Func<RCt_MDMediaFileRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MDMediaFileRecordList ToList<T>(T[] array, Func <T, RCt_MDMediaFileRecord> converter) {
			RLt_MDMediaFileRecordList result = new RLt_MDMediaFileRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MDMediaFileRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MDMediaFileRecord> converter) {
			RLt_MDMediaFileRecordList result = new RLt_MDMediaFileRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MDMediaFileRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMediaFileRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MDMediaFileRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MDMediaFileRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MDMediaFileRecord> NewList() {
			return new RLt_MDMediaFileRecordList();
		}


	} // RLt_MDMediaFileRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUAlbumMediaRecordList</code> that represents a record list of
	///  <code>t_MUAlbumMedia</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUAlbumMediaRecordList: GenericRecordList<RCt_MUAlbumMediaRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUAlbumMediaRecord GetElementDefaultValue() {
			return new RCt_MUAlbumMediaRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUAlbumMediaRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUAlbumMediaRecordList recordlist, Func<RCt_MUAlbumMediaRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUAlbumMediaRecordList ToList<T>(T[] array, Func <T, RCt_MUAlbumMediaRecord> converter) {
			RLt_MUAlbumMediaRecordList result = new RLt_MUAlbumMediaRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUAlbumMediaRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUAlbumMediaRecord> converter) {
			RLt_MUAlbumMediaRecordList result = new RLt_MUAlbumMediaRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUAlbumMediaRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumMediaRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUAlbumMediaRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUAlbumMediaRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(5, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUAlbumMediaRecord> NewList() {
			return new RLt_MUAlbumMediaRecordList();
		}


	} // RLt_MUAlbumMediaRecordList

	/// <summary>
	/// RecordList type <code>RLt_MUArtistEventRecordList</code> that represents a record list of
	///  <code>t_MUArtistEvent</code>
	/// </summary>
	[Serializable()]
	public partial class RLt_MUArtistEventRecordList: GenericRecordList<RCt_MUArtistEventRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCt_MUArtistEventRecord GetElementDefaultValue() {
			return new RCt_MUArtistEventRecord("");
		}

		public T[] ToArray<T>(Func<RCt_MUArtistEventRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLt_MUArtistEventRecordList recordlist, Func<RCt_MUArtistEventRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}

		public static RLt_MUArtistEventRecordList ToList<T>(T[] array, Func <T, RCt_MUArtistEventRecord> converter) {
			RLt_MUArtistEventRecordList result = new RLt_MUArtistEventRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLt_MUArtistEventRecordList FromRestList<T>(RestList<T> restList, Func <T, RCt_MUArtistEventRecord> converter) {
			RLt_MUArtistEventRecordList result = new RLt_MUArtistEventRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLt_MUArtistEventRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistEventRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLt_MUArtistEventRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLt_MUArtistEventRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = new BitArray(4, false);
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCt_MUArtistEventRecord> NewList() {
			return new RLt_MUArtistEventRecordList();
		}


	} // RLt_MUArtistEventRecordList
}
