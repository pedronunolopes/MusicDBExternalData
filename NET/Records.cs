using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssMusicDBExternalData {

	/// <summary>
	/// Structure <code>RCt_MUEventRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUEventRecord: ISerializable, ITypedRecord<RCt_MUEventRecord> {
		private static readonly GlobalObjectKey Idt_MUEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Vi0ywUhSlaJ7QYL28Z4srA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUEvent")]
		public ENt_MUEventEntityRecord ssENt_MUEvent;


		public static implicit operator ENt_MUEventEntityRecord(RCt_MUEventRecord r) {
			return r.ssENt_MUEvent;
		}

		public static implicit operator RCt_MUEventRecord(ENt_MUEventEntityRecord r) {
			RCt_MUEventRecord res = new RCt_MUEventRecord(null);
			res.ssENt_MUEvent = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUEvent.ChangedAttributes = value;
			}
			get {
				return ssENt_MUEvent.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUEventRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUEvent = new ENt_MUEventEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(10, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUEvent.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUEvent.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUEvent.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUEventRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUEventRecord a, RCt_MUEventRecord b) {
			if (a.ssENt_MUEvent != b.ssENt_MUEvent) return false;
			return true;
		}

		public static bool operator != (RCt_MUEventRecord a, RCt_MUEventRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUEventRecord)) return false;
			return (this == (RCt_MUEventRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUEvent.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUEventRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUEvent = new ENt_MUEventEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUEvent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUEvent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUEvent = (ENt_MUEventEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUEvent.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUEvent.InternalRecursiveSave();
		}


		public RCt_MUEventRecord Duplicate() {
			RCt_MUEventRecord t;
			t.ssENt_MUEvent = (ENt_MUEventEntityRecord) this.ssENt_MUEvent.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUEvent.ToXml(this, recordElem, "t_MUEvent", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muevent") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUEvent")) variable.Value = ssENt_MUEvent; else variable.Optimized = true;
				variable.SetFieldName("t_muevent");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUEvent.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUEvent.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUEvent) {
				return ssENt_MUEvent;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUEvent.FillFromOther((IRecord) other.AttributeGet(Idt_MUEvent));
		}
		public bool IsDefault() {
			RCt_MUEventRecord defaultStruct = new RCt_MUEventRecord(null);
			if (this.ssENt_MUEvent != defaultStruct.ssENt_MUEvent) return false;
			return true;
		}
	} // RCt_MUEventRecord

	/// <summary>
	/// Structure <code>RCt_MUAlbumSongRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUAlbumSongRecord: ISerializable, ITypedRecord<RCt_MUAlbumSongRecord> {
		private static readonly GlobalObjectKey Idt_MUAlbumSong = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BOWS7SMzLpRtctfzNNJ1jA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUAlbumSong")]
		public ENt_MUAlbumSongEntityRecord ssENt_MUAlbumSong;


		public static implicit operator ENt_MUAlbumSongEntityRecord(RCt_MUAlbumSongRecord r) {
			return r.ssENt_MUAlbumSong;
		}

		public static implicit operator RCt_MUAlbumSongRecord(ENt_MUAlbumSongEntityRecord r) {
			RCt_MUAlbumSongRecord res = new RCt_MUAlbumSongRecord(null);
			res.ssENt_MUAlbumSong = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUAlbumSong.ChangedAttributes = value;
			}
			get {
				return ssENt_MUAlbumSong.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUAlbumSongRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUAlbumSong = new ENt_MUAlbumSongEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUAlbumSong.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUAlbumSong.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUAlbumSong.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUAlbumSong.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUAlbumSongRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUAlbumSongRecord a, RCt_MUAlbumSongRecord b) {
			if (a.ssENt_MUAlbumSong != b.ssENt_MUAlbumSong) return false;
			return true;
		}

		public static bool operator != (RCt_MUAlbumSongRecord a, RCt_MUAlbumSongRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUAlbumSongRecord)) return false;
			return (this == (RCt_MUAlbumSongRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUAlbumSong.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUAlbumSongRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUAlbumSong = new ENt_MUAlbumSongEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUAlbumSong", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUAlbumSong' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUAlbumSong.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUAlbumSong.InternalRecursiveSave();
		}


		public RCt_MUAlbumSongRecord Duplicate() {
			RCt_MUAlbumSongRecord t;
			t.ssENt_MUAlbumSong = (ENt_MUAlbumSongEntityRecord) this.ssENt_MUAlbumSong.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUAlbumSong.ToXml(this, recordElem, "t_MUAlbumSong", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mualbumsong") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUAlbumSong")) variable.Value = ssENt_MUAlbumSong; else variable.Optimized = true;
				variable.SetFieldName("t_mualbumsong");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbumSong.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbumSong.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUAlbumSong) {
				return ssENt_MUAlbumSong;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUAlbumSong.FillFromOther((IRecord) other.AttributeGet(Idt_MUAlbumSong));
		}
		public bool IsDefault() {
			RCt_MUAlbumSongRecord defaultStruct = new RCt_MUAlbumSongRecord(null);
			if (this.ssENt_MUAlbumSong != defaultStruct.ssENt_MUAlbumSong) return false;
			return true;
		}
	} // RCt_MUAlbumSongRecord

	/// <summary>
	/// Structure <code>RCt_MUSongRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUSongRecord: ISerializable, ITypedRecord<RCt_MUSongRecord> {
		private static readonly GlobalObjectKey Idt_MUSong = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*69I_h2x33C5KWCLIJDqzuA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUSong")]
		public ENt_MUSongEntityRecord ssENt_MUSong;


		public static implicit operator ENt_MUSongEntityRecord(RCt_MUSongRecord r) {
			return r.ssENt_MUSong;
		}

		public static implicit operator RCt_MUSongRecord(ENt_MUSongEntityRecord r) {
			RCt_MUSongRecord res = new RCt_MUSongRecord(null);
			res.ssENt_MUSong = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUSong.ChangedAttributes = value;
			}
			get {
				return ssENt_MUSong.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUSongRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUSong = new ENt_MUSongEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(7, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUSong.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUSong.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUSong.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUSong.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUSongRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUSongRecord a, RCt_MUSongRecord b) {
			if (a.ssENt_MUSong != b.ssENt_MUSong) return false;
			return true;
		}

		public static bool operator != (RCt_MUSongRecord a, RCt_MUSongRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUSongRecord)) return false;
			return (this == (RCt_MUSongRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUSong.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUSongRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUSong = new ENt_MUSongEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUSong", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUSong' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUSong = (ENt_MUSongEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUSong.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUSong.InternalRecursiveSave();
		}


		public RCt_MUSongRecord Duplicate() {
			RCt_MUSongRecord t;
			t.ssENt_MUSong = (ENt_MUSongEntityRecord) this.ssENt_MUSong.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUSong.ToXml(this, recordElem, "t_MUSong", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_musong") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUSong")) variable.Value = ssENt_MUSong; else variable.Optimized = true;
				variable.SetFieldName("t_musong");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUSong.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUSong.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUSong) {
				return ssENt_MUSong;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUSong.FillFromOther((IRecord) other.AttributeGet(Idt_MUSong));
		}
		public bool IsDefault() {
			RCt_MUSongRecord defaultStruct = new RCt_MUSongRecord(null);
			if (this.ssENt_MUSong != defaultStruct.ssENt_MUSong) return false;
			return true;
		}
	} // RCt_MUSongRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistMusicStyleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistMusicStyleRecord: ISerializable, ITypedRecord<RCt_MUArtistMusicStyleRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistMusicStyle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_9gx9xkpKa0TrZ8htnA9Mg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistMusicStyle")]
		public ENt_MUArtistMusicStyleEntityRecord ssENt_MUArtistMusicStyle;


		public static implicit operator ENt_MUArtistMusicStyleEntityRecord(RCt_MUArtistMusicStyleRecord r) {
			return r.ssENt_MUArtistMusicStyle;
		}

		public static implicit operator RCt_MUArtistMusicStyleRecord(ENt_MUArtistMusicStyleEntityRecord r) {
			RCt_MUArtistMusicStyleRecord res = new RCt_MUArtistMusicStyleRecord(null);
			res.ssENt_MUArtistMusicStyle = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistMusicStyle.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistMusicStyle.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistMusicStyleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistMusicStyle = new ENt_MUArtistMusicStyleEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistMusicStyle.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistMusicStyle.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistMusicStyle.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistMusicStyle.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistMusicStyleRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistMusicStyleRecord a, RCt_MUArtistMusicStyleRecord b) {
			if (a.ssENt_MUArtistMusicStyle != b.ssENt_MUArtistMusicStyle) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistMusicStyleRecord a, RCt_MUArtistMusicStyleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistMusicStyleRecord)) return false;
			return (this == (RCt_MUArtistMusicStyleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistMusicStyle.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistMusicStyleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistMusicStyle = new ENt_MUArtistMusicStyleEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistMusicStyle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistMusicStyle' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistMusicStyle.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistMusicStyle.InternalRecursiveSave();
		}


		public RCt_MUArtistMusicStyleRecord Duplicate() {
			RCt_MUArtistMusicStyleRecord t;
			t.ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord) this.ssENt_MUArtistMusicStyle.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistMusicStyle.ToXml(this, recordElem, "t_MUArtistMusicStyle", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistmusicstyle") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistMusicStyle")) variable.Value = ssENt_MUArtistMusicStyle; else variable.Optimized = true;
				variable.SetFieldName("t_muartistmusicstyle");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistMusicStyle.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistMusicStyle.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistMusicStyle) {
				return ssENt_MUArtistMusicStyle;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistMusicStyle.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistMusicStyle));
		}
		public bool IsDefault() {
			RCt_MUArtistMusicStyleRecord defaultStruct = new RCt_MUArtistMusicStyleRecord(null);
			if (this.ssENt_MUArtistMusicStyle != defaultStruct.ssENt_MUArtistMusicStyle) return false;
			return true;
		}
	} // RCt_MUArtistMusicStyleRecord

	/// <summary>
	/// Structure <code>RCt_MDMusicStyleRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDMusicStyleRecord: ISerializable, ITypedRecord<RCt_MDMusicStyleRecord> {
		private static readonly GlobalObjectKey Idt_MDMusicStyle = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HNhUh_cNO23UMNHG+giVQA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDMusicStyle")]
		public ENt_MDMusicStyleEntityRecord ssENt_MDMusicStyle;


		public static implicit operator ENt_MDMusicStyleEntityRecord(RCt_MDMusicStyleRecord r) {
			return r.ssENt_MDMusicStyle;
		}

		public static implicit operator RCt_MDMusicStyleRecord(ENt_MDMusicStyleEntityRecord r) {
			RCt_MDMusicStyleRecord res = new RCt_MDMusicStyleRecord(null);
			res.ssENt_MDMusicStyle = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDMusicStyle.ChangedAttributes = value;
			}
			get {
				return ssENt_MDMusicStyle.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDMusicStyleRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDMusicStyle = new ENt_MDMusicStyleEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDMusicStyle.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDMusicStyle.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDMusicStyle.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDMusicStyle.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDMusicStyleRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDMusicStyleRecord a, RCt_MDMusicStyleRecord b) {
			if (a.ssENt_MDMusicStyle != b.ssENt_MDMusicStyle) return false;
			return true;
		}

		public static bool operator != (RCt_MDMusicStyleRecord a, RCt_MDMusicStyleRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDMusicStyleRecord)) return false;
			return (this == (RCt_MDMusicStyleRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDMusicStyle.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDMusicStyleRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDMusicStyle = new ENt_MDMusicStyleEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDMusicStyle", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDMusicStyle' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDMusicStyle.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDMusicStyle.InternalRecursiveSave();
		}


		public RCt_MDMusicStyleRecord Duplicate() {
			RCt_MDMusicStyleRecord t;
			t.ssENt_MDMusicStyle = (ENt_MDMusicStyleEntityRecord) this.ssENt_MDMusicStyle.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDMusicStyle.ToXml(this, recordElem, "t_MDMusicStyle", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdmusicstyle") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDMusicStyle")) variable.Value = ssENt_MDMusicStyle; else variable.Optimized = true;
				variable.SetFieldName("t_mdmusicstyle");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMusicStyle.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMusicStyle.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDMusicStyle) {
				return ssENt_MDMusicStyle;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDMusicStyle.FillFromOther((IRecord) other.AttributeGet(Idt_MDMusicStyle));
		}
		public bool IsDefault() {
			RCt_MDMusicStyleRecord defaultStruct = new RCt_MDMusicStyleRecord(null);
			if (this.ssENt_MDMusicStyle != defaultStruct.ssENt_MDMusicStyle) return false;
			return true;
		}
	} // RCt_MDMusicStyleRecord

	/// <summary>
	/// Structure <code>RCt_MDCountryRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDCountryRecord: ISerializable, ITypedRecord<RCt_MDCountryRecord> {
		private static readonly GlobalObjectKey Idt_MDCountry = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7VPODjkmtAQ5QhQOEK4oDQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDCountry")]
		public ENt_MDCountryEntityRecord ssENt_MDCountry;


		public static implicit operator ENt_MDCountryEntityRecord(RCt_MDCountryRecord r) {
			return r.ssENt_MDCountry;
		}

		public static implicit operator RCt_MDCountryRecord(ENt_MDCountryEntityRecord r) {
			RCt_MDCountryRecord res = new RCt_MDCountryRecord(null);
			res.ssENt_MDCountry = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDCountry.ChangedAttributes = value;
			}
			get {
				return ssENt_MDCountry.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDCountryRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDCountry = new ENt_MDCountryEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDCountry.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDCountry.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDCountry.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDCountry.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDCountryRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDCountryRecord a, RCt_MDCountryRecord b) {
			if (a.ssENt_MDCountry != b.ssENt_MDCountry) return false;
			return true;
		}

		public static bool operator != (RCt_MDCountryRecord a, RCt_MDCountryRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDCountryRecord)) return false;
			return (this == (RCt_MDCountryRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDCountry.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDCountryRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDCountry = new ENt_MDCountryEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDCountry", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDCountry' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDCountry = (ENt_MDCountryEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDCountry.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDCountry.InternalRecursiveSave();
		}


		public RCt_MDCountryRecord Duplicate() {
			RCt_MDCountryRecord t;
			t.ssENt_MDCountry = (ENt_MDCountryEntityRecord) this.ssENt_MDCountry.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDCountry.ToXml(this, recordElem, "t_MDCountry", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdcountry") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDCountry")) variable.Value = ssENt_MDCountry; else variable.Optimized = true;
				variable.SetFieldName("t_mdcountry");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDCountry.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDCountry.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDCountry) {
				return ssENt_MDCountry;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDCountry.FillFromOther((IRecord) other.AttributeGet(Idt_MDCountry));
		}
		public bool IsDefault() {
			RCt_MDCountryRecord defaultStruct = new RCt_MDCountryRecord(null);
			if (this.ssENt_MDCountry != defaultStruct.ssENt_MDCountry) return false;
			return true;
		}
	} // RCt_MDCountryRecord

	/// <summary>
	/// Structure <code>RCt_MDEventRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDEventRecord: ISerializable, ITypedRecord<RCt_MDEventRecord> {
		private static readonly GlobalObjectKey Idt_MDEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8ZopLcdWAnx9EUq1G2gEbg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDEvent")]
		public ENt_MDEventEntityRecord ssENt_MDEvent;


		public static implicit operator ENt_MDEventEntityRecord(RCt_MDEventRecord r) {
			return r.ssENt_MDEvent;
		}

		public static implicit operator RCt_MDEventRecord(ENt_MDEventEntityRecord r) {
			RCt_MDEventRecord res = new RCt_MDEventRecord(null);
			res.ssENt_MDEvent = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDEvent.ChangedAttributes = value;
			}
			get {
				return ssENt_MDEvent.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDEventRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDEvent = new ENt_MDEventEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDEvent.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDEvent.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDEvent.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDEventRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDEventRecord a, RCt_MDEventRecord b) {
			if (a.ssENt_MDEvent != b.ssENt_MDEvent) return false;
			return true;
		}

		public static bool operator != (RCt_MDEventRecord a, RCt_MDEventRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDEventRecord)) return false;
			return (this == (RCt_MDEventRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDEvent.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDEventRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDEvent = new ENt_MDEventEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDEvent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDEvent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDEvent = (ENt_MDEventEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDEvent.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDEvent.InternalRecursiveSave();
		}


		public RCt_MDEventRecord Duplicate() {
			RCt_MDEventRecord t;
			t.ssENt_MDEvent = (ENt_MDEventEntityRecord) this.ssENt_MDEvent.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDEvent.ToXml(this, recordElem, "t_MDEvent", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdevent") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDEvent")) variable.Value = ssENt_MDEvent; else variable.Optimized = true;
				variable.SetFieldName("t_mdevent");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDEvent.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDEvent.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDEvent) {
				return ssENt_MDEvent;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDEvent.FillFromOther((IRecord) other.AttributeGet(Idt_MDEvent));
		}
		public bool IsDefault() {
			RCt_MDEventRecord defaultStruct = new RCt_MDEventRecord(null);
			if (this.ssENt_MDEvent != defaultStruct.ssENt_MDEvent) return false;
			return true;
		}
	} // RCt_MDEventRecord

	/// <summary>
	/// Structure <code>RCt_MUAlbumRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUAlbumRecord: ISerializable, ITypedRecord<RCt_MUAlbumRecord> {
		private static readonly GlobalObjectKey Idt_MUAlbum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*o2ts_a6c9RI3CkMu9vxykg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUAlbum")]
		public ENt_MUAlbumEntityRecord ssENt_MUAlbum;


		public static implicit operator ENt_MUAlbumEntityRecord(RCt_MUAlbumRecord r) {
			return r.ssENt_MUAlbum;
		}

		public static implicit operator RCt_MUAlbumRecord(ENt_MUAlbumEntityRecord r) {
			RCt_MUAlbumRecord res = new RCt_MUAlbumRecord(null);
			res.ssENt_MUAlbum = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUAlbum.ChangedAttributes = value;
			}
			get {
				return ssENt_MUAlbum.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUAlbumRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUAlbum = new ENt_MUAlbumEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(7, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUAlbum.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUAlbum.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUAlbum.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUAlbum.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUAlbumRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUAlbumRecord a, RCt_MUAlbumRecord b) {
			if (a.ssENt_MUAlbum != b.ssENt_MUAlbum) return false;
			return true;
		}

		public static bool operator != (RCt_MUAlbumRecord a, RCt_MUAlbumRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUAlbumRecord)) return false;
			return (this == (RCt_MUAlbumRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUAlbum.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUAlbumRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUAlbum = new ENt_MUAlbumEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUAlbum", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUAlbum' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUAlbum = (ENt_MUAlbumEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUAlbum.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUAlbum.InternalRecursiveSave();
		}


		public RCt_MUAlbumRecord Duplicate() {
			RCt_MUAlbumRecord t;
			t.ssENt_MUAlbum = (ENt_MUAlbumEntityRecord) this.ssENt_MUAlbum.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUAlbum.ToXml(this, recordElem, "t_MUAlbum", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mualbum") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUAlbum")) variable.Value = ssENt_MUAlbum; else variable.Optimized = true;
				variable.SetFieldName("t_mualbum");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbum.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbum.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUAlbum) {
				return ssENt_MUAlbum;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUAlbum.FillFromOther((IRecord) other.AttributeGet(Idt_MUAlbum));
		}
		public bool IsDefault() {
			RCt_MUAlbumRecord defaultStruct = new RCt_MUAlbumRecord(null);
			if (this.ssENt_MUAlbum != defaultStruct.ssENt_MUAlbum) return false;
			return true;
		}
	} // RCt_MUAlbumRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistRecord: ISerializable, ITypedRecord<RCt_MUArtistRecord> {
		private static readonly GlobalObjectKey Idt_MUArtist = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cWYwqdglLVNrVwl3C6GPDw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtist")]
		public ENt_MUArtistEntityRecord ssENt_MUArtist;


		public static implicit operator ENt_MUArtistEntityRecord(RCt_MUArtistRecord r) {
			return r.ssENt_MUArtist;
		}

		public static implicit operator RCt_MUArtistRecord(ENt_MUArtistEntityRecord r) {
			RCt_MUArtistRecord res = new RCt_MUArtistRecord(null);
			res.ssENt_MUArtist = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtist.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtist.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtist = new ENt_MUArtistEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtist.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtist.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtist.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtist.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistRecord a, RCt_MUArtistRecord b) {
			if (a.ssENt_MUArtist != b.ssENt_MUArtist) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistRecord a, RCt_MUArtistRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistRecord)) return false;
			return (this == (RCt_MUArtistRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtist.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtist = new ENt_MUArtistEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtist", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtist' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtist = (ENt_MUArtistEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtist.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtist.InternalRecursiveSave();
		}


		public RCt_MUArtistRecord Duplicate() {
			RCt_MUArtistRecord t;
			t.ssENt_MUArtist = (ENt_MUArtistEntityRecord) this.ssENt_MUArtist.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtist.ToXml(this, recordElem, "t_MUArtist", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartist") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtist")) variable.Value = ssENt_MUArtist; else variable.Optimized = true;
				variable.SetFieldName("t_muartist");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtist.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtist.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtist) {
				return ssENt_MUArtist;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtist.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtist));
		}
		public bool IsDefault() {
			RCt_MUArtistRecord defaultStruct = new RCt_MUArtistRecord(null);
			if (this.ssENt_MUArtist != defaultStruct.ssENt_MUArtist) return false;
			return true;
		}
	} // RCt_MUArtistRecord

	/// <summary>
	/// Structure <code>RCt_VNVenueRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_VNVenueRecord: ISerializable, ITypedRecord<RCt_VNVenueRecord> {
		private static readonly GlobalObjectKey Idt_VNVenue = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BcRPpUuvu2TvGCyuiPAN+w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_VNVenue")]
		public ENt_VNVenueEntityRecord ssENt_VNVenue;


		public static implicit operator ENt_VNVenueEntityRecord(RCt_VNVenueRecord r) {
			return r.ssENt_VNVenue;
		}

		public static implicit operator RCt_VNVenueRecord(ENt_VNVenueEntityRecord r) {
			RCt_VNVenueRecord res = new RCt_VNVenueRecord(null);
			res.ssENt_VNVenue = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_VNVenue.ChangedAttributes = value;
			}
			get {
				return ssENt_VNVenue.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_VNVenueRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_VNVenue = new ENt_VNVenueEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(11, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_VNVenue.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_VNVenue.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_VNVenue.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_VNVenue.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_VNVenueRecord r) {
			this = r;
		}


		public static bool operator == (RCt_VNVenueRecord a, RCt_VNVenueRecord b) {
			if (a.ssENt_VNVenue != b.ssENt_VNVenue) return false;
			return true;
		}

		public static bool operator != (RCt_VNVenueRecord a, RCt_VNVenueRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_VNVenueRecord)) return false;
			return (this == (RCt_VNVenueRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_VNVenue.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_VNVenueRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_VNVenue = new ENt_VNVenueEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_VNVenue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_VNVenue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_VNVenue = (ENt_VNVenueEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_VNVenue.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_VNVenue.InternalRecursiveSave();
		}


		public RCt_VNVenueRecord Duplicate() {
			RCt_VNVenueRecord t;
			t.ssENt_VNVenue = (ENt_VNVenueEntityRecord) this.ssENt_VNVenue.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_VNVenue.ToXml(this, recordElem, "t_VNVenue", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_vnvenue") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_VNVenue")) variable.Value = ssENt_VNVenue; else variable.Optimized = true;
				variable.SetFieldName("t_vnvenue");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_VNVenue.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_VNVenue.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_VNVenue) {
				return ssENt_VNVenue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_VNVenue.FillFromOther((IRecord) other.AttributeGet(Idt_VNVenue));
		}
		public bool IsDefault() {
			RCt_VNVenueRecord defaultStruct = new RCt_VNVenueRecord(null);
			if (this.ssENt_VNVenue != defaultStruct.ssENt_VNVenue) return false;
			return true;
		}
	} // RCt_VNVenueRecord

	/// <summary>
	/// Structure <code>RCt_MDDataPointRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDDataPointRecord: ISerializable, ITypedRecord<RCt_MDDataPointRecord> {
		private static readonly GlobalObjectKey Idt_MDDataPoint = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZzTpXHhyw+cTx+UIiUegtA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDDataPoint")]
		public ENt_MDDataPointEntityRecord ssENt_MDDataPoint;


		public static implicit operator ENt_MDDataPointEntityRecord(RCt_MDDataPointRecord r) {
			return r.ssENt_MDDataPoint;
		}

		public static implicit operator RCt_MDDataPointRecord(ENt_MDDataPointEntityRecord r) {
			RCt_MDDataPointRecord res = new RCt_MDDataPointRecord(null);
			res.ssENt_MDDataPoint = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDDataPoint.ChangedAttributes = value;
			}
			get {
				return ssENt_MDDataPoint.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDDataPointRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDDataPoint = new ENt_MDDataPointEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDDataPoint.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDDataPoint.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDDataPoint.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDDataPoint.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDDataPointRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDDataPointRecord a, RCt_MDDataPointRecord b) {
			if (a.ssENt_MDDataPoint != b.ssENt_MDDataPoint) return false;
			return true;
		}

		public static bool operator != (RCt_MDDataPointRecord a, RCt_MDDataPointRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDDataPointRecord)) return false;
			return (this == (RCt_MDDataPointRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDDataPoint.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDDataPointRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDDataPoint = new ENt_MDDataPointEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDDataPoint", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDDataPoint' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDDataPoint.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDDataPoint.InternalRecursiveSave();
		}


		public RCt_MDDataPointRecord Duplicate() {
			RCt_MDDataPointRecord t;
			t.ssENt_MDDataPoint = (ENt_MDDataPointEntityRecord) this.ssENt_MDDataPoint.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDDataPoint.ToXml(this, recordElem, "t_MDDataPoint", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mddatapoint") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDDataPoint")) variable.Value = ssENt_MDDataPoint; else variable.Optimized = true;
				variable.SetFieldName("t_mddatapoint");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDDataPoint.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDDataPoint.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDDataPoint) {
				return ssENt_MDDataPoint;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDDataPoint.FillFromOther((IRecord) other.AttributeGet(Idt_MDDataPoint));
		}
		public bool IsDefault() {
			RCt_MDDataPointRecord defaultStruct = new RCt_MDDataPointRecord(null);
			if (this.ssENt_MDDataPoint != defaultStruct.ssENt_MDDataPoint) return false;
			return true;
		}
	} // RCt_MDDataPointRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistSocialMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistSocialMediaRecord: ISerializable, ITypedRecord<RCt_MUArtistSocialMediaRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistSocialMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pldtpkeAzVOINld6ql+4Rg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistSocialMedia")]
		public ENt_MUArtistSocialMediaEntityRecord ssENt_MUArtistSocialMedia;


		public static implicit operator ENt_MUArtistSocialMediaEntityRecord(RCt_MUArtistSocialMediaRecord r) {
			return r.ssENt_MUArtistSocialMedia;
		}

		public static implicit operator RCt_MUArtistSocialMediaRecord(ENt_MUArtistSocialMediaEntityRecord r) {
			RCt_MUArtistSocialMediaRecord res = new RCt_MUArtistSocialMediaRecord(null);
			res.ssENt_MUArtistSocialMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistSocialMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistSocialMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistSocialMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistSocialMedia = new ENt_MUArtistSocialMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistSocialMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistSocialMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistSocialMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistSocialMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistSocialMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistSocialMediaRecord a, RCt_MUArtistSocialMediaRecord b) {
			if (a.ssENt_MUArtistSocialMedia != b.ssENt_MUArtistSocialMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistSocialMediaRecord a, RCt_MUArtistSocialMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistSocialMediaRecord)) return false;
			return (this == (RCt_MUArtistSocialMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistSocialMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistSocialMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistSocialMedia = new ENt_MUArtistSocialMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistSocialMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistSocialMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistSocialMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistSocialMedia.InternalRecursiveSave();
		}


		public RCt_MUArtistSocialMediaRecord Duplicate() {
			RCt_MUArtistSocialMediaRecord t;
			t.ssENt_MUArtistSocialMedia = (ENt_MUArtistSocialMediaEntityRecord) this.ssENt_MUArtistSocialMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistSocialMedia.ToXml(this, recordElem, "t_MUArtistSocialMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistsocialmedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistSocialMedia")) variable.Value = ssENt_MUArtistSocialMedia; else variable.Optimized = true;
				variable.SetFieldName("t_muartistsocialmedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistSocialMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistSocialMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistSocialMedia) {
				return ssENt_MUArtistSocialMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistSocialMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistSocialMedia));
		}
		public bool IsDefault() {
			RCt_MUArtistSocialMediaRecord defaultStruct = new RCt_MUArtistSocialMediaRecord(null);
			if (this.ssENt_MUArtistSocialMedia != defaultStruct.ssENt_MUArtistSocialMedia) return false;
			return true;
		}
	} // RCt_MUArtistSocialMediaRecord

	/// <summary>
	/// Structure <code>RCt_MDSocialMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDSocialMediaRecord: ISerializable, ITypedRecord<RCt_MDSocialMediaRecord> {
		private static readonly GlobalObjectKey Idt_MDSocialMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mKMimxJm6_v11fetPvR5TA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDSocialMedia")]
		public ENt_MDSocialMediaEntityRecord ssENt_MDSocialMedia;


		public static implicit operator ENt_MDSocialMediaEntityRecord(RCt_MDSocialMediaRecord r) {
			return r.ssENt_MDSocialMedia;
		}

		public static implicit operator RCt_MDSocialMediaRecord(ENt_MDSocialMediaEntityRecord r) {
			RCt_MDSocialMediaRecord res = new RCt_MDSocialMediaRecord(null);
			res.ssENt_MDSocialMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDSocialMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MDSocialMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDSocialMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDSocialMedia = new ENt_MDSocialMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDSocialMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDSocialMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDSocialMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDSocialMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDSocialMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDSocialMediaRecord a, RCt_MDSocialMediaRecord b) {
			if (a.ssENt_MDSocialMedia != b.ssENt_MDSocialMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MDSocialMediaRecord a, RCt_MDSocialMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDSocialMediaRecord)) return false;
			return (this == (RCt_MDSocialMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDSocialMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDSocialMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDSocialMedia = new ENt_MDSocialMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDSocialMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDSocialMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDSocialMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDSocialMedia.InternalRecursiveSave();
		}


		public RCt_MDSocialMediaRecord Duplicate() {
			RCt_MDSocialMediaRecord t;
			t.ssENt_MDSocialMedia = (ENt_MDSocialMediaEntityRecord) this.ssENt_MDSocialMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDSocialMedia.ToXml(this, recordElem, "t_MDSocialMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdsocialmedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDSocialMedia")) variable.Value = ssENt_MDSocialMedia; else variable.Optimized = true;
				variable.SetFieldName("t_mdsocialmedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDSocialMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDSocialMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDSocialMedia) {
				return ssENt_MDSocialMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDSocialMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MDSocialMedia));
		}
		public bool IsDefault() {
			RCt_MDSocialMediaRecord defaultStruct = new RCt_MDSocialMediaRecord(null);
			if (this.ssENt_MDSocialMedia != defaultStruct.ssENt_MDSocialMedia) return false;
			return true;
		}
	} // RCt_MDSocialMediaRecord

	/// <summary>
	/// Structure <code>RCt_SMArtistDataPointRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_SMArtistDataPointRecord: ISerializable, ITypedRecord<RCt_SMArtistDataPointRecord> {
		private static readonly GlobalObjectKey Idt_SMArtistDataPoint = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*boW0h+2kqjw4ZjANp99L2A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_SMArtistDataPoint")]
		public ENt_SMArtistDataPointEntityRecord ssENt_SMArtistDataPoint;


		public static implicit operator ENt_SMArtistDataPointEntityRecord(RCt_SMArtistDataPointRecord r) {
			return r.ssENt_SMArtistDataPoint;
		}

		public static implicit operator RCt_SMArtistDataPointRecord(ENt_SMArtistDataPointEntityRecord r) {
			RCt_SMArtistDataPointRecord res = new RCt_SMArtistDataPointRecord(null);
			res.ssENt_SMArtistDataPoint = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_SMArtistDataPoint.ChangedAttributes = value;
			}
			get {
				return ssENt_SMArtistDataPoint.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_SMArtistDataPointRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_SMArtistDataPoint = new ENt_SMArtistDataPointEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(9, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_SMArtistDataPoint.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_SMArtistDataPoint.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_SMArtistDataPoint.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_SMArtistDataPoint.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_SMArtistDataPointRecord r) {
			this = r;
		}


		public static bool operator == (RCt_SMArtistDataPointRecord a, RCt_SMArtistDataPointRecord b) {
			if (a.ssENt_SMArtistDataPoint != b.ssENt_SMArtistDataPoint) return false;
			return true;
		}

		public static bool operator != (RCt_SMArtistDataPointRecord a, RCt_SMArtistDataPointRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_SMArtistDataPointRecord)) return false;
			return (this == (RCt_SMArtistDataPointRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_SMArtistDataPoint.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_SMArtistDataPointRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_SMArtistDataPoint = new ENt_SMArtistDataPointEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_SMArtistDataPoint", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_SMArtistDataPoint' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_SMArtistDataPoint.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_SMArtistDataPoint.InternalRecursiveSave();
		}


		public RCt_SMArtistDataPointRecord Duplicate() {
			RCt_SMArtistDataPointRecord t;
			t.ssENt_SMArtistDataPoint = (ENt_SMArtistDataPointEntityRecord) this.ssENt_SMArtistDataPoint.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_SMArtistDataPoint.ToXml(this, recordElem, "t_SMArtistDataPoint", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_smartistdatapoint") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_SMArtistDataPoint")) variable.Value = ssENt_SMArtistDataPoint; else variable.Optimized = true;
				variable.SetFieldName("t_smartistdatapoint");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_SMArtistDataPoint.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_SMArtistDataPoint.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_SMArtistDataPoint) {
				return ssENt_SMArtistDataPoint;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_SMArtistDataPoint.FillFromOther((IRecord) other.AttributeGet(Idt_SMArtistDataPoint));
		}
		public bool IsDefault() {
			RCt_SMArtistDataPointRecord defaultStruct = new RCt_SMArtistDataPointRecord(null);
			if (this.ssENt_SMArtistDataPoint != defaultStruct.ssENt_SMArtistDataPoint) return false;
			return true;
		}
	} // RCt_SMArtistDataPointRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistCorrelationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistCorrelationRecord: ISerializable, ITypedRecord<RCt_MUArtistCorrelationRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistCorrelation = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*43GuJG9YSe0PA_LVXVvH_A");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistCorrelation")]
		public ENt_MUArtistCorrelationEntityRecord ssENt_MUArtistCorrelation;


		public static implicit operator ENt_MUArtistCorrelationEntityRecord(RCt_MUArtistCorrelationRecord r) {
			return r.ssENt_MUArtistCorrelation;
		}

		public static implicit operator RCt_MUArtistCorrelationRecord(ENt_MUArtistCorrelationEntityRecord r) {
			RCt_MUArtistCorrelationRecord res = new RCt_MUArtistCorrelationRecord(null);
			res.ssENt_MUArtistCorrelation = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistCorrelation.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistCorrelation.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistCorrelationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistCorrelation = new ENt_MUArtistCorrelationEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(6, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistCorrelation.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistCorrelation.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistCorrelation.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistCorrelation.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistCorrelationRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistCorrelationRecord a, RCt_MUArtistCorrelationRecord b) {
			if (a.ssENt_MUArtistCorrelation != b.ssENt_MUArtistCorrelation) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistCorrelationRecord a, RCt_MUArtistCorrelationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistCorrelationRecord)) return false;
			return (this == (RCt_MUArtistCorrelationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistCorrelation.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistCorrelationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistCorrelation = new ENt_MUArtistCorrelationEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistCorrelation", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistCorrelation' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistCorrelation.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistCorrelation.InternalRecursiveSave();
		}


		public RCt_MUArtistCorrelationRecord Duplicate() {
			RCt_MUArtistCorrelationRecord t;
			t.ssENt_MUArtistCorrelation = (ENt_MUArtistCorrelationEntityRecord) this.ssENt_MUArtistCorrelation.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistCorrelation.ToXml(this, recordElem, "t_MUArtistCorrelation", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistcorrelation") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistCorrelation")) variable.Value = ssENt_MUArtistCorrelation; else variable.Optimized = true;
				variable.SetFieldName("t_muartistcorrelation");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistCorrelation.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistCorrelation.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistCorrelation) {
				return ssENt_MUArtistCorrelation;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistCorrelation.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistCorrelation));
		}
		public bool IsDefault() {
			RCt_MUArtistCorrelationRecord defaultStruct = new RCt_MUArtistCorrelationRecord(null);
			if (this.ssENt_MUArtistCorrelation != defaultStruct.ssENt_MUArtistCorrelation) return false;
			return true;
		}
	} // RCt_MUArtistCorrelationRecord

	/// <summary>
	/// Structure <code>RCt_MGPromoterRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MGPromoterRecord: ISerializable, ITypedRecord<RCt_MGPromoterRecord> {
		private static readonly GlobalObjectKey Idt_MGPromoter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dKj8yzhboJLqCO2fYstplA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MGPromoter")]
		public ENt_MGPromoterEntityRecord ssENt_MGPromoter;


		public static implicit operator ENt_MGPromoterEntityRecord(RCt_MGPromoterRecord r) {
			return r.ssENt_MGPromoter;
		}

		public static implicit operator RCt_MGPromoterRecord(ENt_MGPromoterEntityRecord r) {
			RCt_MGPromoterRecord res = new RCt_MGPromoterRecord(null);
			res.ssENt_MGPromoter = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MGPromoter.ChangedAttributes = value;
			}
			get {
				return ssENt_MGPromoter.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MGPromoterRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MGPromoter = new ENt_MGPromoterEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(6, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MGPromoter.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MGPromoter.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MGPromoter.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MGPromoter.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MGPromoterRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MGPromoterRecord a, RCt_MGPromoterRecord b) {
			if (a.ssENt_MGPromoter != b.ssENt_MGPromoter) return false;
			return true;
		}

		public static bool operator != (RCt_MGPromoterRecord a, RCt_MGPromoterRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MGPromoterRecord)) return false;
			return (this == (RCt_MGPromoterRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MGPromoter.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MGPromoterRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MGPromoter = new ENt_MGPromoterEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MGPromoter", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MGPromoter' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MGPromoter = (ENt_MGPromoterEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MGPromoter.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MGPromoter.InternalRecursiveSave();
		}


		public RCt_MGPromoterRecord Duplicate() {
			RCt_MGPromoterRecord t;
			t.ssENt_MGPromoter = (ENt_MGPromoterEntityRecord) this.ssENt_MGPromoter.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MGPromoter.ToXml(this, recordElem, "t_MGPromoter", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mgpromoter") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MGPromoter")) variable.Value = ssENt_MGPromoter; else variable.Optimized = true;
				variable.SetFieldName("t_mgpromoter");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGPromoter.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGPromoter.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MGPromoter) {
				return ssENt_MGPromoter;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MGPromoter.FillFromOther((IRecord) other.AttributeGet(Idt_MGPromoter));
		}
		public bool IsDefault() {
			RCt_MGPromoterRecord defaultStruct = new RCt_MGPromoterRecord(null);
			if (this.ssENt_MGPromoter != defaultStruct.ssENt_MGPromoter) return false;
			return true;
		}
	} // RCt_MGPromoterRecord

	/// <summary>
	/// Structure <code>RCt_MDContactRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDContactRecord: ISerializable, ITypedRecord<RCt_MDContactRecord> {
		private static readonly GlobalObjectKey Idt_MDContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*m2MUxd70ePrYGUS2T6Kiyw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDContact")]
		public ENt_MDContactEntityRecord ssENt_MDContact;


		public static implicit operator ENt_MDContactEntityRecord(RCt_MDContactRecord r) {
			return r.ssENt_MDContact;
		}

		public static implicit operator RCt_MDContactRecord(ENt_MDContactEntityRecord r) {
			RCt_MDContactRecord res = new RCt_MDContactRecord(null);
			res.ssENt_MDContact = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDContact.ChangedAttributes = value;
			}
			get {
				return ssENt_MDContact.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDContactRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDContact = new ENt_MDContactEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDContact.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDContact.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDContact.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDContact.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDContactRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDContactRecord a, RCt_MDContactRecord b) {
			if (a.ssENt_MDContact != b.ssENt_MDContact) return false;
			return true;
		}

		public static bool operator != (RCt_MDContactRecord a, RCt_MDContactRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDContactRecord)) return false;
			return (this == (RCt_MDContactRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDContact.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDContactRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDContact = new ENt_MDContactEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDContact", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDContact' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDContact = (ENt_MDContactEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDContact.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDContact.InternalRecursiveSave();
		}


		public RCt_MDContactRecord Duplicate() {
			RCt_MDContactRecord t;
			t.ssENt_MDContact = (ENt_MDContactEntityRecord) this.ssENt_MDContact.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDContact.ToXml(this, recordElem, "t_MDContact", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdcontact") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDContact")) variable.Value = ssENt_MDContact; else variable.Optimized = true;
				variable.SetFieldName("t_mdcontact");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDContact.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDContact.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDContact) {
				return ssENt_MDContact;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDContact.FillFromOther((IRecord) other.AttributeGet(Idt_MDContact));
		}
		public bool IsDefault() {
			RCt_MDContactRecord defaultStruct = new RCt_MDContactRecord(null);
			if (this.ssENt_MDContact != defaultStruct.ssENt_MDContact) return false;
			return true;
		}
	} // RCt_MDContactRecord

	/// <summary>
	/// Structure <code>RCt_CTContactRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_CTContactRecord: ISerializable, ITypedRecord<RCt_CTContactRecord> {
		private static readonly GlobalObjectKey Idt_CTContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T_HGtc7O9hv+IMdx_IFHxg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_CTContact")]
		public ENt_CTContactEntityRecord ssENt_CTContact;


		public static implicit operator ENt_CTContactEntityRecord(RCt_CTContactRecord r) {
			return r.ssENt_CTContact;
		}

		public static implicit operator RCt_CTContactRecord(ENt_CTContactEntityRecord r) {
			RCt_CTContactRecord res = new RCt_CTContactRecord(null);
			res.ssENt_CTContact = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_CTContact.ChangedAttributes = value;
			}
			get {
				return ssENt_CTContact.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_CTContactRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_CTContact = new ENt_CTContactEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(8, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_CTContact.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_CTContact.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_CTContact.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_CTContact.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_CTContactRecord r) {
			this = r;
		}


		public static bool operator == (RCt_CTContactRecord a, RCt_CTContactRecord b) {
			if (a.ssENt_CTContact != b.ssENt_CTContact) return false;
			return true;
		}

		public static bool operator != (RCt_CTContactRecord a, RCt_CTContactRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_CTContactRecord)) return false;
			return (this == (RCt_CTContactRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_CTContact.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_CTContactRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_CTContact = new ENt_CTContactEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_CTContact", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_CTContact' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_CTContact = (ENt_CTContactEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_CTContact.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_CTContact.InternalRecursiveSave();
		}


		public RCt_CTContactRecord Duplicate() {
			RCt_CTContactRecord t;
			t.ssENt_CTContact = (ENt_CTContactEntityRecord) this.ssENt_CTContact.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_CTContact.ToXml(this, recordElem, "t_CTContact", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_ctcontact") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_CTContact")) variable.Value = ssENt_CTContact; else variable.Optimized = true;
				variable.SetFieldName("t_ctcontact");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_CTContact.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_CTContact.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_CTContact) {
				return ssENt_CTContact;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_CTContact.FillFromOther((IRecord) other.AttributeGet(Idt_CTContact));
		}
		public bool IsDefault() {
			RCt_CTContactRecord defaultStruct = new RCt_CTContactRecord(null);
			if (this.ssENt_CTContact != defaultStruct.ssENt_CTContact) return false;
			return true;
		}
	} // RCt_CTContactRecord

	/// <summary>
	/// Structure <code>RCt_MGPromoterContactRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MGPromoterContactRecord: ISerializable, ITypedRecord<RCt_MGPromoterContactRecord> {
		private static readonly GlobalObjectKey Idt_MGPromoterContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WJ_PqoaeUpK5GZjtNV0LkA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MGPromoterContact")]
		public ENt_MGPromoterContactEntityRecord ssENt_MGPromoterContact;


		public static implicit operator ENt_MGPromoterContactEntityRecord(RCt_MGPromoterContactRecord r) {
			return r.ssENt_MGPromoterContact;
		}

		public static implicit operator RCt_MGPromoterContactRecord(ENt_MGPromoterContactEntityRecord r) {
			RCt_MGPromoterContactRecord res = new RCt_MGPromoterContactRecord(null);
			res.ssENt_MGPromoterContact = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MGPromoterContact.ChangedAttributes = value;
			}
			get {
				return ssENt_MGPromoterContact.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MGPromoterContactRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MGPromoterContact = new ENt_MGPromoterContactEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MGPromoterContact.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MGPromoterContact.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MGPromoterContact.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MGPromoterContact.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MGPromoterContactRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MGPromoterContactRecord a, RCt_MGPromoterContactRecord b) {
			if (a.ssENt_MGPromoterContact != b.ssENt_MGPromoterContact) return false;
			return true;
		}

		public static bool operator != (RCt_MGPromoterContactRecord a, RCt_MGPromoterContactRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MGPromoterContactRecord)) return false;
			return (this == (RCt_MGPromoterContactRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MGPromoterContact.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MGPromoterContactRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MGPromoterContact = new ENt_MGPromoterContactEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MGPromoterContact", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MGPromoterContact' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MGPromoterContact.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MGPromoterContact.InternalRecursiveSave();
		}


		public RCt_MGPromoterContactRecord Duplicate() {
			RCt_MGPromoterContactRecord t;
			t.ssENt_MGPromoterContact = (ENt_MGPromoterContactEntityRecord) this.ssENt_MGPromoterContact.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MGPromoterContact.ToXml(this, recordElem, "t_MGPromoterContact", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mgpromotercontact") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MGPromoterContact")) variable.Value = ssENt_MGPromoterContact; else variable.Optimized = true;
				variable.SetFieldName("t_mgpromotercontact");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGPromoterContact.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGPromoterContact.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MGPromoterContact) {
				return ssENt_MGPromoterContact;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MGPromoterContact.FillFromOther((IRecord) other.AttributeGet(Idt_MGPromoterContact));
		}
		public bool IsDefault() {
			RCt_MGPromoterContactRecord defaultStruct = new RCt_MGPromoterContactRecord(null);
			if (this.ssENt_MGPromoterContact != defaultStruct.ssENt_MGPromoterContact) return false;
			return true;
		}
	} // RCt_MGPromoterContactRecord

	/// <summary>
	/// Structure <code>RCt_MGFestivalContactRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MGFestivalContactRecord: ISerializable, ITypedRecord<RCt_MGFestivalContactRecord> {
		private static readonly GlobalObjectKey Idt_MGFestivalContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bA9P5SWioAbNa1aZA4u38w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MGFestivalContact")]
		public ENt_MGFestivalContactEntityRecord ssENt_MGFestivalContact;


		public static implicit operator ENt_MGFestivalContactEntityRecord(RCt_MGFestivalContactRecord r) {
			return r.ssENt_MGFestivalContact;
		}

		public static implicit operator RCt_MGFestivalContactRecord(ENt_MGFestivalContactEntityRecord r) {
			RCt_MGFestivalContactRecord res = new RCt_MGFestivalContactRecord(null);
			res.ssENt_MGFestivalContact = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MGFestivalContact.ChangedAttributes = value;
			}
			get {
				return ssENt_MGFestivalContact.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MGFestivalContactRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MGFestivalContact = new ENt_MGFestivalContactEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MGFestivalContact.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MGFestivalContact.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MGFestivalContact.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MGFestivalContact.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MGFestivalContactRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MGFestivalContactRecord a, RCt_MGFestivalContactRecord b) {
			if (a.ssENt_MGFestivalContact != b.ssENt_MGFestivalContact) return false;
			return true;
		}

		public static bool operator != (RCt_MGFestivalContactRecord a, RCt_MGFestivalContactRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MGFestivalContactRecord)) return false;
			return (this == (RCt_MGFestivalContactRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MGFestivalContact.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MGFestivalContactRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MGFestivalContact = new ENt_MGFestivalContactEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MGFestivalContact", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MGFestivalContact' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MGFestivalContact.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MGFestivalContact.InternalRecursiveSave();
		}


		public RCt_MGFestivalContactRecord Duplicate() {
			RCt_MGFestivalContactRecord t;
			t.ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord) this.ssENt_MGFestivalContact.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MGFestivalContact.ToXml(this, recordElem, "t_MGFestivalContact", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mgfestivalcontact") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MGFestivalContact")) variable.Value = ssENt_MGFestivalContact; else variable.Optimized = true;
				variable.SetFieldName("t_mgfestivalcontact");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGFestivalContact.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGFestivalContact.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MGFestivalContact) {
				return ssENt_MGFestivalContact;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MGFestivalContact.FillFromOther((IRecord) other.AttributeGet(Idt_MGFestivalContact));
		}
		public bool IsDefault() {
			RCt_MGFestivalContactRecord defaultStruct = new RCt_MGFestivalContactRecord(null);
			if (this.ssENt_MGFestivalContact != defaultStruct.ssENt_MGFestivalContact) return false;
			return true;
		}
	} // RCt_MGFestivalContactRecord

	/// <summary>
	/// Structure <code>RCt_MGFestivalRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MGFestivalRecord: ISerializable, ITypedRecord<RCt_MGFestivalRecord> {
		private static readonly GlobalObjectKey Idt_MGFestival = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_YNiK7IqHG36cfpcZg8RVw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MGFestival")]
		public ENt_MGFestivalEntityRecord ssENt_MGFestival;


		public static implicit operator ENt_MGFestivalEntityRecord(RCt_MGFestivalRecord r) {
			return r.ssENt_MGFestival;
		}

		public static implicit operator RCt_MGFestivalRecord(ENt_MGFestivalEntityRecord r) {
			RCt_MGFestivalRecord res = new RCt_MGFestivalRecord(null);
			res.ssENt_MGFestival = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MGFestival.ChangedAttributes = value;
			}
			get {
				return ssENt_MGFestival.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MGFestivalRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MGFestival = new ENt_MGFestivalEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(6, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MGFestival.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MGFestival.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MGFestival.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MGFestival.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MGFestivalRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MGFestivalRecord a, RCt_MGFestivalRecord b) {
			if (a.ssENt_MGFestival != b.ssENt_MGFestival) return false;
			return true;
		}

		public static bool operator != (RCt_MGFestivalRecord a, RCt_MGFestivalRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MGFestivalRecord)) return false;
			return (this == (RCt_MGFestivalRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MGFestival.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MGFestivalRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MGFestival = new ENt_MGFestivalEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MGFestival", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MGFestival' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MGFestival = (ENt_MGFestivalEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MGFestival.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MGFestival.InternalRecursiveSave();
		}


		public RCt_MGFestivalRecord Duplicate() {
			RCt_MGFestivalRecord t;
			t.ssENt_MGFestival = (ENt_MGFestivalEntityRecord) this.ssENt_MGFestival.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MGFestival.ToXml(this, recordElem, "t_MGFestival", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mgfestival") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MGFestival")) variable.Value = ssENt_MGFestival; else variable.Optimized = true;
				variable.SetFieldName("t_mgfestival");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGFestival.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MGFestival.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MGFestival) {
				return ssENt_MGFestival;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MGFestival.FillFromOther((IRecord) other.AttributeGet(Idt_MGFestival));
		}
		public bool IsDefault() {
			RCt_MGFestivalRecord defaultStruct = new RCt_MGFestivalRecord(null);
			if (this.ssENt_MGFestival != defaultStruct.ssENt_MGFestival) return false;
			return true;
		}
	} // RCt_MGFestivalRecord

	/// <summary>
	/// Structure <code>RCt_VNVenueContactRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_VNVenueContactRecord: ISerializable, ITypedRecord<RCt_VNVenueContactRecord> {
		private static readonly GlobalObjectKey Idt_VNVenueContact = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*wStZMrieEBQxTDFZIwP6jw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_VNVenueContact")]
		public ENt_VNVenueContactEntityRecord ssENt_VNVenueContact;


		public static implicit operator ENt_VNVenueContactEntityRecord(RCt_VNVenueContactRecord r) {
			return r.ssENt_VNVenueContact;
		}

		public static implicit operator RCt_VNVenueContactRecord(ENt_VNVenueContactEntityRecord r) {
			RCt_VNVenueContactRecord res = new RCt_VNVenueContactRecord(null);
			res.ssENt_VNVenueContact = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_VNVenueContact.ChangedAttributes = value;
			}
			get {
				return ssENt_VNVenueContact.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_VNVenueContactRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_VNVenueContact = new ENt_VNVenueContactEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_VNVenueContact.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_VNVenueContact.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_VNVenueContact.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_VNVenueContact.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_VNVenueContactRecord r) {
			this = r;
		}


		public static bool operator == (RCt_VNVenueContactRecord a, RCt_VNVenueContactRecord b) {
			if (a.ssENt_VNVenueContact != b.ssENt_VNVenueContact) return false;
			return true;
		}

		public static bool operator != (RCt_VNVenueContactRecord a, RCt_VNVenueContactRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_VNVenueContactRecord)) return false;
			return (this == (RCt_VNVenueContactRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_VNVenueContact.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_VNVenueContactRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_VNVenueContact = new ENt_VNVenueContactEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_VNVenueContact", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_VNVenueContact' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_VNVenueContact.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_VNVenueContact.InternalRecursiveSave();
		}


		public RCt_VNVenueContactRecord Duplicate() {
			RCt_VNVenueContactRecord t;
			t.ssENt_VNVenueContact = (ENt_VNVenueContactEntityRecord) this.ssENt_VNVenueContact.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_VNVenueContact.ToXml(this, recordElem, "t_VNVenueContact", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_vnvenuecontact") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_VNVenueContact")) variable.Value = ssENt_VNVenueContact; else variable.Optimized = true;
				variable.SetFieldName("t_vnvenuecontact");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_VNVenueContact.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_VNVenueContact.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_VNVenueContact) {
				return ssENt_VNVenueContact;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_VNVenueContact.FillFromOther((IRecord) other.AttributeGet(Idt_VNVenueContact));
		}
		public bool IsDefault() {
			RCt_VNVenueContactRecord defaultStruct = new RCt_VNVenueContactRecord(null);
			if (this.ssENt_VNVenueContact != defaultStruct.ssENt_VNVenueContact) return false;
			return true;
		}
	} // RCt_VNVenueContactRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistDataSetRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistDataSetRecord: ISerializable, ITypedRecord<RCt_MUArtistDataSetRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistDataSet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0J7lNbIiyi+EHghVZ_eTSA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistDataSet")]
		public ENt_MUArtistDataSetEntityRecord ssENt_MUArtistDataSet;


		public static implicit operator ENt_MUArtistDataSetEntityRecord(RCt_MUArtistDataSetRecord r) {
			return r.ssENt_MUArtistDataSet;
		}

		public static implicit operator RCt_MUArtistDataSetRecord(ENt_MUArtistDataSetEntityRecord r) {
			RCt_MUArtistDataSetRecord res = new RCt_MUArtistDataSetRecord(null);
			res.ssENt_MUArtistDataSet = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistDataSet.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistDataSet.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistDataSetRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistDataSet = new ENt_MUArtistDataSetEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistDataSet.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistDataSet.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistDataSet.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistDataSet.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistDataSetRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistDataSetRecord a, RCt_MUArtistDataSetRecord b) {
			if (a.ssENt_MUArtistDataSet != b.ssENt_MUArtistDataSet) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistDataSetRecord a, RCt_MUArtistDataSetRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistDataSetRecord)) return false;
			return (this == (RCt_MUArtistDataSetRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistDataSet.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistDataSetRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistDataSet = new ENt_MUArtistDataSetEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistDataSet", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistDataSet' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistDataSet.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistDataSet.InternalRecursiveSave();
		}


		public RCt_MUArtistDataSetRecord Duplicate() {
			RCt_MUArtistDataSetRecord t;
			t.ssENt_MUArtistDataSet = (ENt_MUArtistDataSetEntityRecord) this.ssENt_MUArtistDataSet.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistDataSet.ToXml(this, recordElem, "t_MUArtistDataSet", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistdataset") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistDataSet")) variable.Value = ssENt_MUArtistDataSet; else variable.Optimized = true;
				variable.SetFieldName("t_muartistdataset");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistDataSet.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistDataSet.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistDataSet) {
				return ssENt_MUArtistDataSet;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistDataSet.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistDataSet));
		}
		public bool IsDefault() {
			RCt_MUArtistDataSetRecord defaultStruct = new RCt_MUArtistDataSetRecord(null);
			if (this.ssENt_MUArtistDataSet != defaultStruct.ssENt_MUArtistDataSet) return false;
			return true;
		}
	} // RCt_MUArtistDataSetRecord

	/// <summary>
	/// Structure <code>RCt_STDataSetRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_STDataSetRecord: ISerializable, ITypedRecord<RCt_STDataSetRecord> {
		private static readonly GlobalObjectKey Idt_STDataSet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*m_nt8xYiCgBXbkF4s4_5Kg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_STDataSet")]
		public ENt_STDataSetEntityRecord ssENt_STDataSet;


		public static implicit operator ENt_STDataSetEntityRecord(RCt_STDataSetRecord r) {
			return r.ssENt_STDataSet;
		}

		public static implicit operator RCt_STDataSetRecord(ENt_STDataSetEntityRecord r) {
			RCt_STDataSetRecord res = new RCt_STDataSetRecord(null);
			res.ssENt_STDataSet = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_STDataSet.ChangedAttributes = value;
			}
			get {
				return ssENt_STDataSet.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_STDataSetRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_STDataSet = new ENt_STDataSetEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(6, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_STDataSet.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_STDataSet.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_STDataSet.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_STDataSet.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_STDataSetRecord r) {
			this = r;
		}


		public static bool operator == (RCt_STDataSetRecord a, RCt_STDataSetRecord b) {
			if (a.ssENt_STDataSet != b.ssENt_STDataSet) return false;
			return true;
		}

		public static bool operator != (RCt_STDataSetRecord a, RCt_STDataSetRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_STDataSetRecord)) return false;
			return (this == (RCt_STDataSetRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_STDataSet.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_STDataSetRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_STDataSet = new ENt_STDataSetEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_STDataSet", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_STDataSet' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_STDataSet = (ENt_STDataSetEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_STDataSet.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_STDataSet.InternalRecursiveSave();
		}


		public RCt_STDataSetRecord Duplicate() {
			RCt_STDataSetRecord t;
			t.ssENt_STDataSet = (ENt_STDataSetEntityRecord) this.ssENt_STDataSet.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_STDataSet.ToXml(this, recordElem, "t_STDataSet", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_stdataset") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_STDataSet")) variable.Value = ssENt_STDataSet; else variable.Optimized = true;
				variable.SetFieldName("t_stdataset");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_STDataSet.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_STDataSet.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_STDataSet) {
				return ssENt_STDataSet;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_STDataSet.FillFromOther((IRecord) other.AttributeGet(Idt_STDataSet));
		}
		public bool IsDefault() {
			RCt_STDataSetRecord defaultStruct = new RCt_STDataSetRecord(null);
			if (this.ssENt_STDataSet != defaultStruct.ssENt_STDataSet) return false;
			return true;
		}
	} // RCt_STDataSetRecord

	/// <summary>
	/// Structure <code>RCt_STDataPointRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_STDataPointRecord: ISerializable, ITypedRecord<RCt_STDataPointRecord> {
		private static readonly GlobalObjectKey Idt_STDataPoint = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UHoAJJnZ8kJ5znWK3WMYJA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_STDataPoint")]
		public ENt_STDataPointEntityRecord ssENt_STDataPoint;


		public static implicit operator ENt_STDataPointEntityRecord(RCt_STDataPointRecord r) {
			return r.ssENt_STDataPoint;
		}

		public static implicit operator RCt_STDataPointRecord(ENt_STDataPointEntityRecord r) {
			RCt_STDataPointRecord res = new RCt_STDataPointRecord(null);
			res.ssENt_STDataPoint = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_STDataPoint.ChangedAttributes = value;
			}
			get {
				return ssENt_STDataPoint.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_STDataPointRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_STDataPoint = new ENt_STDataPointEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(9, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_STDataPoint.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_STDataPoint.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_STDataPoint.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_STDataPoint.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_STDataPointRecord r) {
			this = r;
		}


		public static bool operator == (RCt_STDataPointRecord a, RCt_STDataPointRecord b) {
			if (a.ssENt_STDataPoint != b.ssENt_STDataPoint) return false;
			return true;
		}

		public static bool operator != (RCt_STDataPointRecord a, RCt_STDataPointRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_STDataPointRecord)) return false;
			return (this == (RCt_STDataPointRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_STDataPoint.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_STDataPointRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_STDataPoint = new ENt_STDataPointEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_STDataPoint", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_STDataPoint' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_STDataPoint = (ENt_STDataPointEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_STDataPoint.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_STDataPoint.InternalRecursiveSave();
		}


		public RCt_STDataPointRecord Duplicate() {
			RCt_STDataPointRecord t;
			t.ssENt_STDataPoint = (ENt_STDataPointEntityRecord) this.ssENt_STDataPoint.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_STDataPoint.ToXml(this, recordElem, "t_STDataPoint", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_stdatapoint") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_STDataPoint")) variable.Value = ssENt_STDataPoint; else variable.Optimized = true;
				variable.SetFieldName("t_stdatapoint");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_STDataPoint.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_STDataPoint.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_STDataPoint) {
				return ssENt_STDataPoint;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_STDataPoint.FillFromOther((IRecord) other.AttributeGet(Idt_STDataPoint));
		}
		public bool IsDefault() {
			RCt_STDataPointRecord defaultStruct = new RCt_STDataPointRecord(null);
			if (this.ssENt_STDataPoint != defaultStruct.ssENt_STDataPoint) return false;
			return true;
		}
	} // RCt_STDataPointRecord

	/// <summary>
	/// Structure <code>RCt_MDDataSetRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDDataSetRecord: ISerializable, ITypedRecord<RCt_MDDataSetRecord> {
		private static readonly GlobalObjectKey Idt_MDDataSet = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GLSBC5_Qwnprxu1efOuUBw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDDataSet")]
		public ENt_MDDataSetEntityRecord ssENt_MDDataSet;


		public static implicit operator ENt_MDDataSetEntityRecord(RCt_MDDataSetRecord r) {
			return r.ssENt_MDDataSet;
		}

		public static implicit operator RCt_MDDataSetRecord(ENt_MDDataSetEntityRecord r) {
			RCt_MDDataSetRecord res = new RCt_MDDataSetRecord(null);
			res.ssENt_MDDataSet = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDDataSet.ChangedAttributes = value;
			}
			get {
				return ssENt_MDDataSet.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDDataSetRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDDataSet = new ENt_MDDataSetEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDDataSet.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDDataSet.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDDataSet.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDDataSet.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDDataSetRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDDataSetRecord a, RCt_MDDataSetRecord b) {
			if (a.ssENt_MDDataSet != b.ssENt_MDDataSet) return false;
			return true;
		}

		public static bool operator != (RCt_MDDataSetRecord a, RCt_MDDataSetRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDDataSetRecord)) return false;
			return (this == (RCt_MDDataSetRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDDataSet.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDDataSetRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDDataSet = new ENt_MDDataSetEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDDataSet", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDDataSet' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDDataSet = (ENt_MDDataSetEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDDataSet.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDDataSet.InternalRecursiveSave();
		}


		public RCt_MDDataSetRecord Duplicate() {
			RCt_MDDataSetRecord t;
			t.ssENt_MDDataSet = (ENt_MDDataSetEntityRecord) this.ssENt_MDDataSet.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDDataSet.ToXml(this, recordElem, "t_MDDataSet", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mddataset") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDDataSet")) variable.Value = ssENt_MDDataSet; else variable.Optimized = true;
				variable.SetFieldName("t_mddataset");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDDataSet.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDDataSet.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDDataSet) {
				return ssENt_MDDataSet;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDDataSet.FillFromOther((IRecord) other.AttributeGet(Idt_MDDataSet));
		}
		public bool IsDefault() {
			RCt_MDDataSetRecord defaultStruct = new RCt_MDDataSetRecord(null);
			if (this.ssENt_MDDataSet != defaultStruct.ssENt_MDDataSet) return false;
			return true;
		}
	} // RCt_MDDataSetRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistAlbumRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistAlbumRecord: ISerializable, ITypedRecord<RCt_MUArtistAlbumRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistAlbum = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8aXWQ6VsHxAl90GwpH9MhA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistAlbum")]
		public ENt_MUArtistAlbumEntityRecord ssENt_MUArtistAlbum;


		public static implicit operator ENt_MUArtistAlbumEntityRecord(RCt_MUArtistAlbumRecord r) {
			return r.ssENt_MUArtistAlbum;
		}

		public static implicit operator RCt_MUArtistAlbumRecord(ENt_MUArtistAlbumEntityRecord r) {
			RCt_MUArtistAlbumRecord res = new RCt_MUArtistAlbumRecord(null);
			res.ssENt_MUArtistAlbum = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistAlbum.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistAlbum.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistAlbumRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistAlbum = new ENt_MUArtistAlbumEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistAlbum.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistAlbum.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistAlbum.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistAlbum.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistAlbumRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistAlbumRecord a, RCt_MUArtistAlbumRecord b) {
			if (a.ssENt_MUArtistAlbum != b.ssENt_MUArtistAlbum) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistAlbumRecord a, RCt_MUArtistAlbumRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistAlbumRecord)) return false;
			return (this == (RCt_MUArtistAlbumRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistAlbum.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistAlbumRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistAlbum = new ENt_MUArtistAlbumEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistAlbum", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistAlbum' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistAlbum.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistAlbum.InternalRecursiveSave();
		}


		public RCt_MUArtistAlbumRecord Duplicate() {
			RCt_MUArtistAlbumRecord t;
			t.ssENt_MUArtistAlbum = (ENt_MUArtistAlbumEntityRecord) this.ssENt_MUArtistAlbum.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistAlbum.ToXml(this, recordElem, "t_MUArtistAlbum", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistalbum") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistAlbum")) variable.Value = ssENt_MUArtistAlbum; else variable.Optimized = true;
				variable.SetFieldName("t_muartistalbum");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistAlbum.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistAlbum.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistAlbum) {
				return ssENt_MUArtistAlbum;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistAlbum.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistAlbum));
		}
		public bool IsDefault() {
			RCt_MUArtistAlbumRecord defaultStruct = new RCt_MUArtistAlbumRecord(null);
			if (this.ssENt_MUArtistAlbum != defaultStruct.ssENt_MUArtistAlbum) return false;
			return true;
		}
	} // RCt_MUArtistAlbumRecord

	/// <summary>
	/// Structure <code>RCt_MDMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDMediaRecord: ISerializable, ITypedRecord<RCt_MDMediaRecord> {
		private static readonly GlobalObjectKey Idt_MDMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NmgdYuZTdRMkk1grS54cGg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDMedia")]
		public ENt_MDMediaEntityRecord ssENt_MDMedia;


		public static implicit operator ENt_MDMediaEntityRecord(RCt_MDMediaRecord r) {
			return r.ssENt_MDMedia;
		}

		public static implicit operator RCt_MDMediaRecord(ENt_MDMediaEntityRecord r) {
			RCt_MDMediaRecord res = new RCt_MDMediaRecord(null);
			res.ssENt_MDMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MDMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDMedia = new ENt_MDMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDMediaRecord a, RCt_MDMediaRecord b) {
			if (a.ssENt_MDMedia != b.ssENt_MDMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MDMediaRecord a, RCt_MDMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDMediaRecord)) return false;
			return (this == (RCt_MDMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDMedia = new ENt_MDMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDMedia = (ENt_MDMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDMedia.InternalRecursiveSave();
		}


		public RCt_MDMediaRecord Duplicate() {
			RCt_MDMediaRecord t;
			t.ssENt_MDMedia = (ENt_MDMediaEntityRecord) this.ssENt_MDMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDMedia.ToXml(this, recordElem, "t_MDMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdmedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDMedia")) variable.Value = ssENt_MDMedia; else variable.Optimized = true;
				variable.SetFieldName("t_mdmedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDMedia) {
				return ssENt_MDMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MDMedia));
		}
		public bool IsDefault() {
			RCt_MDMediaRecord defaultStruct = new RCt_MDMediaRecord(null);
			if (this.ssENt_MDMedia != defaultStruct.ssENt_MDMedia) return false;
			return true;
		}
	} // RCt_MDMediaRecord

	/// <summary>
	/// Structure <code>RCt_MTMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MTMediaRecord: ISerializable, ITypedRecord<RCt_MTMediaRecord> {
		private static readonly GlobalObjectKey Idt_MTMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZMyyuG+DnJktHiONLcOASA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MTMedia")]
		public ENt_MTMediaEntityRecord ssENt_MTMedia;


		public static implicit operator ENt_MTMediaEntityRecord(RCt_MTMediaRecord r) {
			return r.ssENt_MTMedia;
		}

		public static implicit operator RCt_MTMediaRecord(ENt_MTMediaEntityRecord r) {
			RCt_MTMediaRecord res = new RCt_MTMediaRecord(null);
			res.ssENt_MTMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MTMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MTMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MTMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MTMedia = new ENt_MTMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(7, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MTMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MTMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MTMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MTMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MTMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MTMediaRecord a, RCt_MTMediaRecord b) {
			if (a.ssENt_MTMedia != b.ssENt_MTMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MTMediaRecord a, RCt_MTMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MTMediaRecord)) return false;
			return (this == (RCt_MTMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MTMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MTMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MTMedia = new ENt_MTMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MTMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MTMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MTMedia = (ENt_MTMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MTMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MTMedia.InternalRecursiveSave();
		}


		public RCt_MTMediaRecord Duplicate() {
			RCt_MTMediaRecord t;
			t.ssENt_MTMedia = (ENt_MTMediaEntityRecord) this.ssENt_MTMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MTMedia.ToXml(this, recordElem, "t_MTMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mtmedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MTMedia")) variable.Value = ssENt_MTMedia; else variable.Optimized = true;
				variable.SetFieldName("t_mtmedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MTMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MTMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MTMedia) {
				return ssENt_MTMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MTMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MTMedia));
		}
		public bool IsDefault() {
			RCt_MTMediaRecord defaultStruct = new RCt_MTMediaRecord(null);
			if (this.ssENt_MTMedia != defaultStruct.ssENt_MTMedia) return false;
			return true;
		}
	} // RCt_MTMediaRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistMediaRecord: ISerializable, ITypedRecord<RCt_MUArtistMediaRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YAsu+kK36uFTXWvbB8dPmQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistMedia")]
		public ENt_MUArtistMediaEntityRecord ssENt_MUArtistMedia;


		public static implicit operator ENt_MUArtistMediaEntityRecord(RCt_MUArtistMediaRecord r) {
			return r.ssENt_MUArtistMedia;
		}

		public static implicit operator RCt_MUArtistMediaRecord(ENt_MUArtistMediaEntityRecord r) {
			RCt_MUArtistMediaRecord res = new RCt_MUArtistMediaRecord(null);
			res.ssENt_MUArtistMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistMedia = new ENt_MUArtistMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistMediaRecord a, RCt_MUArtistMediaRecord b) {
			if (a.ssENt_MUArtistMedia != b.ssENt_MUArtistMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistMediaRecord a, RCt_MUArtistMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistMediaRecord)) return false;
			return (this == (RCt_MUArtistMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistMedia = new ENt_MUArtistMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistMedia.InternalRecursiveSave();
		}


		public RCt_MUArtistMediaRecord Duplicate() {
			RCt_MUArtistMediaRecord t;
			t.ssENt_MUArtistMedia = (ENt_MUArtistMediaEntityRecord) this.ssENt_MUArtistMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistMedia.ToXml(this, recordElem, "t_MUArtistMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistmedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistMedia")) variable.Value = ssENt_MUArtistMedia; else variable.Optimized = true;
				variable.SetFieldName("t_muartistmedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistMedia) {
				return ssENt_MUArtistMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistMedia));
		}
		public bool IsDefault() {
			RCt_MUArtistMediaRecord defaultStruct = new RCt_MUArtistMediaRecord(null);
			if (this.ssENt_MUArtistMedia != defaultStruct.ssENt_MUArtistMedia) return false;
			return true;
		}
	} // RCt_MUArtistMediaRecord

	/// <summary>
	/// Structure <code>RCt_MDMediaFileRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MDMediaFileRecord: ISerializable, ITypedRecord<RCt_MDMediaFileRecord> {
		private static readonly GlobalObjectKey Idt_MDMediaFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*coeHIal0nNCFW92MI2y0gg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MDMediaFile")]
		public ENt_MDMediaFileEntityRecord ssENt_MDMediaFile;


		public static implicit operator ENt_MDMediaFileEntityRecord(RCt_MDMediaFileRecord r) {
			return r.ssENt_MDMediaFile;
		}

		public static implicit operator RCt_MDMediaFileRecord(ENt_MDMediaFileEntityRecord r) {
			RCt_MDMediaFileRecord res = new RCt_MDMediaFileRecord(null);
			res.ssENt_MDMediaFile = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MDMediaFile.ChangedAttributes = value;
			}
			get {
				return ssENt_MDMediaFile.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MDMediaFileRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MDMediaFile = new ENt_MDMediaFileEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MDMediaFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MDMediaFile.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MDMediaFile.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MDMediaFile.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MDMediaFileRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MDMediaFileRecord a, RCt_MDMediaFileRecord b) {
			if (a.ssENt_MDMediaFile != b.ssENt_MDMediaFile) return false;
			return true;
		}

		public static bool operator != (RCt_MDMediaFileRecord a, RCt_MDMediaFileRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MDMediaFileRecord)) return false;
			return (this == (RCt_MDMediaFileRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MDMediaFile.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MDMediaFileRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MDMediaFile = new ENt_MDMediaFileEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MDMediaFile", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MDMediaFile' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MDMediaFile.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MDMediaFile.InternalRecursiveSave();
		}


		public RCt_MDMediaFileRecord Duplicate() {
			RCt_MDMediaFileRecord t;
			t.ssENt_MDMediaFile = (ENt_MDMediaFileEntityRecord) this.ssENt_MDMediaFile.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MDMediaFile.ToXml(this, recordElem, "t_MDMediaFile", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mdmediafile") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MDMediaFile")) variable.Value = ssENt_MDMediaFile; else variable.Optimized = true;
				variable.SetFieldName("t_mdmediafile");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMediaFile.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MDMediaFile.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MDMediaFile) {
				return ssENt_MDMediaFile;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MDMediaFile.FillFromOther((IRecord) other.AttributeGet(Idt_MDMediaFile));
		}
		public bool IsDefault() {
			RCt_MDMediaFileRecord defaultStruct = new RCt_MDMediaFileRecord(null);
			if (this.ssENt_MDMediaFile != defaultStruct.ssENt_MDMediaFile) return false;
			return true;
		}
	} // RCt_MDMediaFileRecord

	/// <summary>
	/// Structure <code>RCt_MUAlbumMediaRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUAlbumMediaRecord: ISerializable, ITypedRecord<RCt_MUAlbumMediaRecord> {
		private static readonly GlobalObjectKey Idt_MUAlbumMedia = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ak+mpjR6jzDLHAt52X5gaw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUAlbumMedia")]
		public ENt_MUAlbumMediaEntityRecord ssENt_MUAlbumMedia;


		public static implicit operator ENt_MUAlbumMediaEntityRecord(RCt_MUAlbumMediaRecord r) {
			return r.ssENt_MUAlbumMedia;
		}

		public static implicit operator RCt_MUAlbumMediaRecord(ENt_MUAlbumMediaEntityRecord r) {
			RCt_MUAlbumMediaRecord res = new RCt_MUAlbumMediaRecord(null);
			res.ssENt_MUAlbumMedia = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUAlbumMedia.ChangedAttributes = value;
			}
			get {
				return ssENt_MUAlbumMedia.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUAlbumMediaRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUAlbumMedia = new ENt_MUAlbumMediaEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(5, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUAlbumMedia.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUAlbumMedia.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUAlbumMedia.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUAlbumMedia.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUAlbumMediaRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUAlbumMediaRecord a, RCt_MUAlbumMediaRecord b) {
			if (a.ssENt_MUAlbumMedia != b.ssENt_MUAlbumMedia) return false;
			return true;
		}

		public static bool operator != (RCt_MUAlbumMediaRecord a, RCt_MUAlbumMediaRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUAlbumMediaRecord)) return false;
			return (this == (RCt_MUAlbumMediaRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUAlbumMedia.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUAlbumMediaRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUAlbumMedia = new ENt_MUAlbumMediaEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUAlbumMedia", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUAlbumMedia' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUAlbumMedia.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUAlbumMedia.InternalRecursiveSave();
		}


		public RCt_MUAlbumMediaRecord Duplicate() {
			RCt_MUAlbumMediaRecord t;
			t.ssENt_MUAlbumMedia = (ENt_MUAlbumMediaEntityRecord) this.ssENt_MUAlbumMedia.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUAlbumMedia.ToXml(this, recordElem, "t_MUAlbumMedia", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_mualbummedia") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUAlbumMedia")) variable.Value = ssENt_MUAlbumMedia; else variable.Optimized = true;
				variable.SetFieldName("t_mualbummedia");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbumMedia.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUAlbumMedia.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUAlbumMedia) {
				return ssENt_MUAlbumMedia;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUAlbumMedia.FillFromOther((IRecord) other.AttributeGet(Idt_MUAlbumMedia));
		}
		public bool IsDefault() {
			RCt_MUAlbumMediaRecord defaultStruct = new RCt_MUAlbumMediaRecord(null);
			if (this.ssENt_MUAlbumMedia != defaultStruct.ssENt_MUAlbumMedia) return false;
			return true;
		}
	} // RCt_MUAlbumMediaRecord

	/// <summary>
	/// Structure <code>RCt_MUArtistEventRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCt_MUArtistEventRecord: ISerializable, ITypedRecord<RCt_MUArtistEventRecord> {
		private static readonly GlobalObjectKey Idt_MUArtistEvent = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ZmTJuuuJnkDNj1gFNdaiVQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("t_MUArtistEvent")]
		public ENt_MUArtistEventEntityRecord ssENt_MUArtistEvent;


		public static implicit operator ENt_MUArtistEventEntityRecord(RCt_MUArtistEventRecord r) {
			return r.ssENt_MUArtistEvent;
		}

		public static implicit operator RCt_MUArtistEventRecord(ENt_MUArtistEventEntityRecord r) {
			RCt_MUArtistEventRecord res = new RCt_MUArtistEventRecord(null);
			res.ssENt_MUArtistEvent = r;
			return res;
		}

		public BitArray ChangedAttributes {
			set {
				ssENt_MUArtistEvent.ChangedAttributes = value;
			}
			get {
				return ssENt_MUArtistEvent.ChangedAttributes;
			}
		}
		public BitArray OptimizedAttributes;

		public RCt_MUArtistEventRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssENt_MUArtistEvent = new ENt_MUArtistEventEntityRecord(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = new BitArray(4, false);
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
					ssENt_MUArtistEvent.OptimizedAttributes = GetDefaultOptimizedValues()[0];
				} else {
					ssENt_MUArtistEvent.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = ssENt_MUArtistEvent.OptimizedAttributes;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssENt_MUArtistEvent.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCt_MUArtistEventRecord r) {
			this = r;
		}


		public static bool operator == (RCt_MUArtistEventRecord a, RCt_MUArtistEventRecord b) {
			if (a.ssENt_MUArtistEvent != b.ssENt_MUArtistEvent) return false;
			return true;
		}

		public static bool operator != (RCt_MUArtistEventRecord a, RCt_MUArtistEventRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCt_MUArtistEventRecord)) return false;
			return (this == (RCt_MUArtistEventRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssENt_MUArtistEvent.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCt_MUArtistEventRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssENt_MUArtistEvent = new ENt_MUArtistEventEntityRecord(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssENt_MUArtistEvent", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssENt_MUArtistEvent' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssENt_MUArtistEvent.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssENt_MUArtistEvent.InternalRecursiveSave();
		}


		public RCt_MUArtistEventRecord Duplicate() {
			RCt_MUArtistEventRecord t;
			t.ssENt_MUArtistEvent = (ENt_MUArtistEventEntityRecord) this.ssENt_MUArtistEvent.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssENt_MUArtistEvent.ToXml(this, recordElem, "t_MUArtistEvent", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "t_muartistevent") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".t_MUArtistEvent")) variable.Value = ssENt_MUArtistEvent; else variable.Optimized = true;
				variable.SetFieldName("t_muartistevent");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistEvent.ChangedAttributeGet(key);
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			return ssENt_MUArtistEvent.OptimizedAttributeGet(key);
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == Idt_MUArtistEvent) {
				return ssENt_MUArtistEvent;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssENt_MUArtistEvent.FillFromOther((IRecord) other.AttributeGet(Idt_MUArtistEvent));
		}
		public bool IsDefault() {
			RCt_MUArtistEventRecord defaultStruct = new RCt_MUArtistEventRecord(null);
			if (this.ssENt_MUArtistEvent != defaultStruct.ssENt_MUArtistEvent) return false;
			return true;
		}
	} // RCt_MUArtistEventRecord
}
