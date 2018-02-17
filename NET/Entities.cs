using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssMusicDBExternalData {

	public sealed partial class ENt_MUEventEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUEvent]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "eventid", "EventId"
				}
				, { "eventtypeid", "EventTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "venueid", "VenueId"
				}
				, { "parenteventid", "ParentEventId"
				}
				, { "city", "City"
				}
				, { "date", "Date"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUEventEntity

	/// <summary>
	/// Entity <code>ENt_MUEventEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUEvent</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUEvent", "jtMuyiyt50qgkUAtLZz1WQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUEvent]", null)]
	[Serializable()]
	public partial struct ENt_MUEventEntityRecord: ISerializable, ITypedRecord<ENt_MUEventEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdEventId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*KzZoc0htb0iwWoDoTrJQsA");
		private static readonly GlobalObjectKey IdEventTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*tpUVWaZ2hEG+zc_BSjt+iQ");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Mxmpj3o4aEuDgqFHw2GkgA");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*U3tbhiFvqEuL6qx0xL_NsA");
		private static readonly GlobalObjectKey IdVenueId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*rQlbAoPmJkWxB1ocpfiBvg");
		private static readonly GlobalObjectKey IdParentEventId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fltOEbzE70W4BrDHsJ38SA");
		private static readonly GlobalObjectKey IdCity = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*vGc+jCf9R0qWsKvU9XoEKw");
		private static readonly GlobalObjectKey IdDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*t808Oy7o5EaKBJA+NsjVRw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*MCQSxNmimEyONA2dct+YRQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*eSlNImJ1PkaCJUcMaTcZfg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EventId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("EventId")]
		private long _ssEventId;
		public long ssEventId {
			get {
				return _ssEventId;
			}
			set {
				if ((_ssEventId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(10, true);
					_ssEventId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EventTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("EventTypeId")]
		private int _ssEventTypeId;
		public int ssEventTypeId {
			get {
				return _ssEventTypeId;
			}
			set {
				if ((_ssEventTypeId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssEventTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 500, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 2000, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("VenueId", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("VenueId")]
		private long _ssVenueId;
		public long ssVenueId {
			get {
				return _ssVenueId;
			}
			set {
				if ((_ssVenueId!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssVenueId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ParentEventId", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("ParentEventId")]
		private long _ssParentEventId;
		public long ssParentEventId {
			get {
				return _ssParentEventId;
			}
			set {
				if ((_ssParentEventId!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssParentEventId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("City", 200, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("City")]
		private string _ssCity;
		public string ssCity {
			get {
				return _ssCity;
			}
			set {
				if ((_ssCity!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssCity = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Date", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Date")]
		private DateTime _ssDate;
		public DateTime ssDate {
			get {
				return _ssDate;
			}
			set {
				if ((_ssDate!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[9]) {
					ChangedAttributes[9] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUEventEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(10, true);
			OptimizedAttributes = new BitArray(10, false);
			_ssEventId = 0L;
			_ssEventTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssVenueId = 0L;
			_ssParentEventId = 0L;
			_ssCity = "";
			_ssDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssEventId = r.ReadLongInteger(index++, "t_MUEvent.EventId", 0L);
			ssEventTypeId = r.ReadEntityReference(index++, "t_MUEvent.EventTypeId", 0);
			ssName = r.ReadText(index++, "t_MUEvent.Name", "");
			ssDescription = r.ReadText(index++, "t_MUEvent.Description", "");
			ssVenueId = r.ReadLongInteger(index++, "t_MUEvent.VenueId", 0L);
			ssParentEventId = r.ReadLongInteger(index++, "t_MUEvent.ParentEventId", 0L);
			ssCity = r.ReadText(index++, "t_MUEvent.City", "");
			ssDate = r.ReadDateTime(index++, "t_MUEvent.Date", new DateTime(1900, 1, 1, 0, 0, 0));
			ssInsertDate = r.ReadDateTime(index++, "t_MUEvent.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUEvent.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(10, false);
			OptimizedAttributes = new BitArray(10, false);
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
		public void ReadIM(ENt_MUEventEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUEventEntityRecord a, ENt_MUEventEntityRecord b) {
			if (a.ssEventId != b.ssEventId) return false;
			if (a.ssEventTypeId != b.ssEventTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssVenueId != b.ssVenueId) return false;
			if (a.ssParentEventId != b.ssParentEventId) return false;
			if (a.ssCity != b.ssCity) return false;
			if (a.ssDate != b.ssDate) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUEventEntityRecord a, ENt_MUEventEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUEventEntityRecord)) return false;
			return (this == (ENt_MUEventEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEventId.GetHashCode()
				^ ssEventTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssVenueId.GetHashCode()
				^ ssParentEventId.GetHashCode()
				^ ssCity.GetHashCode()
				^ ssDate.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUEventEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(10, true);
			OptimizedAttributes = new BitArray(10, false);
			_ssEventId = 0L;
			_ssEventTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssVenueId = 0L;
			_ssParentEventId = 0L;
			_ssCity = "";
			_ssDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssEventId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEventId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEventId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssEventTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEventTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEventTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssVenueId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVenueId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVenueId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssParentEventId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssParentEventId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssParentEventId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCity", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCity' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCity = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUEventEntityRecord Duplicate() {
			ENt_MUEventEntityRecord t;
			t._ssEventId = this._ssEventId;
			t._ssEventTypeId = this._ssEventTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssVenueId = this._ssVenueId;
			t._ssParentEventId = this._ssParentEventId;
			t._ssCity = this._ssCity;
			t._ssDate = this._ssDate;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(10);
			t.OptimizedAttributes = new BitArray(10);
			for (int i = 0; i < 10; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EventId")) VarValue.AppendAttribute(recordElem, "EventId", ssEventId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "EventId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EventTypeId")) VarValue.AppendAttribute(recordElem, "EventTypeId", ssEventTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "EventTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.AppendAttribute(recordElem, "VenueId", ssVenueId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "VenueId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ParentEventId")) VarValue.AppendAttribute(recordElem, "ParentEventId", ssParentEventId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ParentEventId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".City")) VarValue.AppendAttribute(recordElem, "City", ssCity, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "City");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Date")) VarValue.AppendAttribute(recordElem, "Date", ssDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "Date");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "eventid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EventId")) variable.Value = ssEventId; else variable.Optimized = true;
			} else if (head == "eventtypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EventTypeId")) variable.Value = ssEventTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "venueid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".VenueId")) variable.Value = ssVenueId; else variable.Optimized = true;
			} else if (head == "parenteventid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ParentEventId")) variable.Value = ssParentEventId; else variable.Optimized = true;
			} else if (head == "city") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".City")) variable.Value = ssCity; else variable.Optimized = true;
			} else if (head == "date") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Date")) variable.Value = ssDate; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdEventTypeId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdVenueId)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdParentEventId)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdCity)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdDate)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[8];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[9];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdEventTypeId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdVenueId)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdParentEventId)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdCity)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdDate)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[8];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[9];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEventId) {
				return ssEventId;
			} else if (key == IdEventTypeId) {
				return ssEventTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdVenueId) {
				return ssVenueId;
			} else if (key == IdParentEventId) {
				return ssParentEventId;
			} else if (key == IdCity) {
				return ssCity;
			} else if (key == IdDate) {
				return ssDate;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(10);
			OptimizedAttributes = new BitArray(10);
			if (other == null) return;
			ssEventId = (long) other.AttributeGet(IdEventId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdEventId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdEventId);
			ssEventTypeId = (int) other.AttributeGet(IdEventTypeId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdEventTypeId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdEventTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDescription);
			ssVenueId = (long) other.AttributeGet(IdVenueId);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdVenueId);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdVenueId);
			ssParentEventId = (long) other.AttributeGet(IdParentEventId);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdParentEventId);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdParentEventId);
			ssCity = (string) other.AttributeGet(IdCity);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdCity);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCity);
			ssDate = (DateTime) other.AttributeGet(IdDate);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdDate);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdDate);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[9] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[9] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUEventEntityRecord defaultStruct = new ENt_MUEventEntityRecord(null);
			if (this.ssEventId != defaultStruct.ssEventId) return false;
			if (this.ssEventTypeId != defaultStruct.ssEventTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssVenueId != defaultStruct.ssVenueId) return false;
			if (this.ssParentEventId != defaultStruct.ssParentEventId) return false;
			if (this.ssCity != defaultStruct.ssCity) return false;
			if (this.ssDate != defaultStruct.ssDate) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUEventEntityRecord

	public sealed partial class ENt_MUAlbumSongEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUAlbumSong]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "albumid", "AlbumId"
				}
				, { "songid", "SongId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUAlbumSongEntity

	/// <summary>
	/// Entity <code>ENt_MUAlbumSongEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUAlbumSong</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUAlbumSong", "HSsjVWi7p0+6KokqNpjfKg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUAlbumSong]", null)]
	[Serializable()]
	public partial struct ENt_MUAlbumSongEntityRecord: ISerializable, ITypedRecord<ENt_MUAlbumSongEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdAlbumId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*dB2TDPdNGkubNJk+mFvKMg");
		private static readonly GlobalObjectKey IdSongId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*oaPOrRlUuka8dJYw8Ckr1w");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*mjEE6jZuLk6sWIYI1wrgQg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JrLpWPo8PUm3wk4Wiz8y5A");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AlbumId", 0, false, true, true, true)]
		[System.Xml.Serialization.XmlElement("AlbumId")]
		private int _ssAlbumId;
		public int ssAlbumId {
			get {
				return _ssAlbumId;
			}
			set {
				if ((_ssAlbumId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(4, true);
					_ssAlbumId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SongId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("SongId")]
		private long _ssSongId;
		public long ssSongId {
			get {
				return _ssSongId;
			}
			set {
				if ((_ssSongId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssSongId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUAlbumSongEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssAlbumId = 0;
			_ssSongId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAlbumId = r.ReadEntityReference(index++, "t_MUAlbumSong.AlbumId", 0);
			ssSongId = r.ReadEntityReferenceLongInteger(index++, "t_MUAlbumSong.SongId", 0L);
			ssInsertDate = r.ReadDateTime(index++, "t_MUAlbumSong.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUAlbumSong.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MUAlbumSongEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUAlbumSongEntityRecord a, ENt_MUAlbumSongEntityRecord b) {
			if (a.ssAlbumId != b.ssAlbumId) return false;
			if (a.ssSongId != b.ssSongId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUAlbumSongEntityRecord a, ENt_MUAlbumSongEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUAlbumSongEntityRecord)) return false;
			return (this == (ENt_MUAlbumSongEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAlbumId.GetHashCode()
				^ ssSongId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUAlbumSongEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssAlbumId = 0;
			_ssSongId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssAlbumId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAlbumId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAlbumId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssSongId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSongId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSongId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUAlbumSongEntityRecord Duplicate() {
			ENt_MUAlbumSongEntityRecord t;
			t._ssAlbumId = this._ssAlbumId;
			t._ssSongId = this._ssSongId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AlbumId")) VarValue.AppendAttribute(recordElem, "AlbumId", ssAlbumId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "AlbumId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SongId")) VarValue.AppendAttribute(recordElem, "SongId", ssSongId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "SongId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "albumid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AlbumId")) variable.Value = ssAlbumId; else variable.Optimized = true;
			} else if (head == "songid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SongId")) variable.Value = ssSongId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAlbumId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdSongId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAlbumId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdSongId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAlbumId) {
				return ssAlbumId;
			} else if (key == IdSongId) {
				return ssSongId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssAlbumId = (int) other.AttributeGet(IdAlbumId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdAlbumId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAlbumId);
			ssSongId = (long) other.AttributeGet(IdSongId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdSongId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSongId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUAlbumSongEntityRecord defaultStruct = new ENt_MUAlbumSongEntityRecord(null);
			if (this.ssAlbumId != defaultStruct.ssAlbumId) return false;
			if (this.ssSongId != defaultStruct.ssSongId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUAlbumSongEntityRecord

	public sealed partial class ENt_MUSongEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUSong]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "songid", "SongId"
				}
				, { "name", "Name"
				}
				, { "length", "Length"
				}
				, { "releasedate", "ReleaseDate"
				}
				, { "weeksincharts", "WeeksInCharts"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUSongEntity

	/// <summary>
	/// Entity <code>ENt_MUSongEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUSong</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUSong", "92B3GX62v02k1cgutB_e7w", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUSong]", null)]
	[Serializable()]
	public partial struct ENt_MUSongEntityRecord: ISerializable, ITypedRecord<ENt_MUSongEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdSongId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*bxioCvsWKU6mu_MDZanNag");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*I7Li7pV6kkO0Cn1bVqKaCA");
		private static readonly GlobalObjectKey IdLength = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*WGD3DAcnA06_yUF2RQSJVg");
		private static readonly GlobalObjectKey IdReleaseDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*p1Ovz87_R0yhLzahKKd3EQ");
		private static readonly GlobalObjectKey IdWeeksInCharts = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*BCSeCGyQl0ewGR6HY38h+w");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*30fSvwcbgUmy9b2NEQ32SQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*7VSEc6cHPkC6FLrfk0xxvA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SongId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("SongId")]
		private long _ssSongId;
		public long ssSongId {
			get {
				return _ssSongId;
			}
			set {
				if ((_ssSongId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(7, true);
					_ssSongId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Length", 17, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Length")]
		private string _ssLength;
		public string ssLength {
			get {
				return _ssLength;
			}
			set {
				if ((_ssLength!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssLength = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ReleaseDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("ReleaseDate")]
		private DateTime _ssReleaseDate;
		public DateTime ssReleaseDate {
			get {
				return _ssReleaseDate;
			}
			set {
				if ((_ssReleaseDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssReleaseDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("WeeksInCharts", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("WeeksInCharts")]
		private int _ssWeeksInCharts;
		public int ssWeeksInCharts {
			get {
				return _ssWeeksInCharts;
			}
			set {
				if ((_ssWeeksInCharts!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssWeeksInCharts = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUSongEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssSongId = 0L;
			_ssName = "";
			_ssLength = "";
			_ssReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssWeeksInCharts = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSongId = r.ReadLongInteger(index++, "t_MUSong.SongId", 0L);
			ssName = r.ReadText(index++, "t_MUSong.Name", "");
			ssLength = r.ReadText(index++, "t_MUSong.Length", "");
			ssReleaseDate = r.ReadDate(index++, "t_MUSong.ReleaseDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssWeeksInCharts = r.ReadInteger(index++, "t_MUSong.WeeksInCharts", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUSong.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUSong.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(7, false);
			OptimizedAttributes = new BitArray(7, false);
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
		public void ReadIM(ENt_MUSongEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUSongEntityRecord a, ENt_MUSongEntityRecord b) {
			if (a.ssSongId != b.ssSongId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssLength != b.ssLength) return false;
			if (a.ssReleaseDate != b.ssReleaseDate) return false;
			if (a.ssWeeksInCharts != b.ssWeeksInCharts) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUSongEntityRecord a, ENt_MUSongEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUSongEntityRecord)) return false;
			return (this == (ENt_MUSongEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSongId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssLength.GetHashCode()
				^ ssReleaseDate.GetHashCode()
				^ ssWeeksInCharts.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUSongEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssSongId = 0L;
			_ssName = "";
			_ssLength = "";
			_ssReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssWeeksInCharts = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssSongId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSongId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSongId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLength", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLength' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLength = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssReleaseDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssReleaseDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssReleaseDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssWeeksInCharts", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssWeeksInCharts' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssWeeksInCharts = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUSongEntityRecord Duplicate() {
			ENt_MUSongEntityRecord t;
			t._ssSongId = this._ssSongId;
			t._ssName = this._ssName;
			t._ssLength = this._ssLength;
			t._ssReleaseDate = this._ssReleaseDate;
			t._ssWeeksInCharts = this._ssWeeksInCharts;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(7);
			t.OptimizedAttributes = new BitArray(7);
			for (int i = 0; i < 7; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SongId")) VarValue.AppendAttribute(recordElem, "SongId", ssSongId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "SongId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Length")) VarValue.AppendAttribute(recordElem, "Length", ssLength, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Length");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ReleaseDate")) VarValue.AppendAttribute(recordElem, "ReleaseDate", ssReleaseDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "ReleaseDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".WeeksInCharts")) VarValue.AppendAttribute(recordElem, "WeeksInCharts", ssWeeksInCharts, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "WeeksInCharts");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "songid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SongId")) variable.Value = ssSongId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "length") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Length")) variable.Value = ssLength; else variable.Optimized = true;
			} else if (head == "releasedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReleaseDate")) variable.Value = ssReleaseDate; else variable.Optimized = true;
			} else if (head == "weeksincharts") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".WeeksInCharts")) variable.Value = ssWeeksInCharts; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdSongId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdLength)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdReleaseDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdWeeksInCharts)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdSongId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdLength)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdReleaseDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdWeeksInCharts)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSongId) {
				return ssSongId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdLength) {
				return ssLength;
			} else if (key == IdReleaseDate) {
				return ssReleaseDate;
			} else if (key == IdWeeksInCharts) {
				return ssWeeksInCharts;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(7);
			OptimizedAttributes = new BitArray(7);
			if (other == null) return;
			ssSongId = (long) other.AttributeGet(IdSongId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdSongId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSongId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssLength = (string) other.AttributeGet(IdLength);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdLength);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLength);
			ssReleaseDate = (DateTime) other.AttributeGet(IdReleaseDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdReleaseDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdReleaseDate);
			ssWeeksInCharts = (int) other.AttributeGet(IdWeeksInCharts);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdWeeksInCharts);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdWeeksInCharts);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUSongEntityRecord defaultStruct = new ENt_MUSongEntityRecord(null);
			if (this.ssSongId != defaultStruct.ssSongId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssLength != defaultStruct.ssLength) return false;
			if (this.ssReleaseDate != defaultStruct.ssReleaseDate) return false;
			if (this.ssWeeksInCharts != defaultStruct.ssWeeksInCharts) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUSongEntityRecord

	public sealed partial class ENt_MUArtistMusicStyleEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistMusicStyle]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid", "ArtistId"
				}
				, { "musicstyleid", "MusicStyleId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistMusicStyleEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistMusicStyleEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistMusicStyle</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistMusicStyle", "7NNM8FT6ckqAQubdXNogMg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistMusicStyle]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistMusicStyleEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistMusicStyleEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*p8sTp6AFSUCksmzsmIM97A");
		private static readonly GlobalObjectKey IdMusicStyleId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*CT9Q7g0K8UCOP902Tq2+ag");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*8ySAjumn10+AQCXvD+fMUQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*5Vx+GHvh70e4aA_94waSXg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MusicStyleId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MusicStyleId")]
		private int _ssMusicStyleId;
		public int ssMusicStyleId {
			get {
				return _ssMusicStyleId;
			}
			set {
				if ((_ssMusicStyleId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssMusicStyleId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistMusicStyleEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssArtistId = 0;
			_ssMusicStyleId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistMusicStyle.ArtistId", 0);
			ssMusicStyleId = r.ReadEntityReference(index++, "t_MUArtistMusicStyle.MusicStyleId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistMusicStyle.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDate(index++, "t_MUArtistMusicStyle.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MUArtistMusicStyleEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistMusicStyleEntityRecord a, ENt_MUArtistMusicStyleEntityRecord b) {
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssMusicStyleId != b.ssMusicStyleId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistMusicStyleEntityRecord a, ENt_MUArtistMusicStyleEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistMusicStyleEntityRecord)) return false;
			return (this == (ENt_MUArtistMusicStyleEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssMusicStyleId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistMusicStyleEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssArtistId = 0;
			_ssMusicStyleId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssMusicStyleId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMusicStyleId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMusicStyleId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistMusicStyleEntityRecord Duplicate() {
			ENt_MUArtistMusicStyleEntityRecord t;
			t._ssArtistId = this._ssArtistId;
			t._ssMusicStyleId = this._ssMusicStyleId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MusicStyleId")) VarValue.AppendAttribute(recordElem, "MusicStyleId", ssMusicStyleId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "MusicStyleId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "musicstyleid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MusicStyleId")) variable.Value = ssMusicStyleId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdMusicStyleId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdMusicStyleId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdMusicStyleId) {
				return ssMusicStyleId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId);
			ssMusicStyleId = (int) other.AttributeGet(IdMusicStyleId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdMusicStyleId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdMusicStyleId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistMusicStyleEntityRecord defaultStruct = new ENt_MUArtistMusicStyleEntityRecord(null);
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssMusicStyleId != defaultStruct.ssMusicStyleId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistMusicStyleEntityRecord

	public sealed partial class ENt_MDMusicStyleEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDMusicStyle]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "musicstyleid", "MusicStyleId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDMusicStyleEntity

	/// <summary>
	/// Entity <code>ENt_MDMusicStyleEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDMusicStyle</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDMusicStyle", "wNFAZb5upUOX9dn33pWKkA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDMusicStyle]", null)]
	[Serializable()]
	public partial struct ENt_MDMusicStyleEntityRecord: ISerializable, ITypedRecord<ENt_MDMusicStyleEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMusicStyleId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Pb_XsIaDQ02F7i5Jwult_Q");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*LNSQYfU5eUeYR7sA6KTN9A");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*50ip7e7ozEuILNfXcRPoxw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*sRGARjchkkayFr_mjJ_PXg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*D12evbmdkEeVaP8WunelCg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MusicStyleId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("MusicStyleId")]
		private int _ssMusicStyleId;
		public int ssMusicStyleId {
			get {
				return _ssMusicStyleId;
			}
			set {
				if ((_ssMusicStyleId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssMusicStyleId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 500, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 4000, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDMusicStyleEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMusicStyleId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMusicStyleId = r.ReadInteger(index++, "t_MDMusicStyle.MusicStyleId", 0);
			ssName = r.ReadText(index++, "t_MDMusicStyle.Name", "");
			ssDescription = r.ReadText(index++, "t_MDMusicStyle.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDMusicStyle.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDMusicStyle.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDMusicStyleEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDMusicStyleEntityRecord a, ENt_MDMusicStyleEntityRecord b) {
			if (a.ssMusicStyleId != b.ssMusicStyleId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDMusicStyleEntityRecord a, ENt_MDMusicStyleEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDMusicStyleEntityRecord)) return false;
			return (this == (ENt_MDMusicStyleEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMusicStyleId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDMusicStyleEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMusicStyleId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMusicStyleId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMusicStyleId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMusicStyleId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDMusicStyleEntityRecord Duplicate() {
			ENt_MDMusicStyleEntityRecord t;
			t._ssMusicStyleId = this._ssMusicStyleId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MusicStyleId")) VarValue.AppendAttribute(recordElem, "MusicStyleId", ssMusicStyleId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "MusicStyleId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "musicstyleid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MusicStyleId")) variable.Value = ssMusicStyleId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMusicStyleId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMusicStyleId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMusicStyleId) {
				return ssMusicStyleId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssMusicStyleId = (int) other.AttributeGet(IdMusicStyleId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMusicStyleId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMusicStyleId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDMusicStyleEntityRecord defaultStruct = new ENt_MDMusicStyleEntityRecord(null);
			if (this.ssMusicStyleId != defaultStruct.ssMusicStyleId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDMusicStyleEntityRecord

	public sealed partial class ENt_MDCountryEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDCountry]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "iso", "Iso"
				}
				, { "name", "Name"
				}
				, { "printablename", "PrintableName"
				}
				, { "iso3", "Iso3"
				}
				, { "countryid", "CountryId"
				}
			};
		}
	} // ENt_MDCountryEntity

	/// <summary>
	/// Entity <code>ENt_MDCountryEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDCountry</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDCountry", "VSq91iDBIUG6dTJy1LceLg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDCountry]", null)]
	[Serializable()]
	public partial struct ENt_MDCountryEntityRecord: ISerializable, ITypedRecord<ENt_MDCountryEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdIso = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*mXwSWPvOl02b0XZzHpk8Eg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0iY0JoQPfkOe5JDHZfo9Kg");
		private static readonly GlobalObjectKey IdPrintableName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*yiCVlmqL20K0JV5EFSR3Eg");
		private static readonly GlobalObjectKey IdIso3 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*NyFG7y8FrE+FsGPneviOvA");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*eEFLOLEfy0++l0nf5V9UTA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Iso", 2, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Iso")]
		private string _ssIso;
		public string ssIso {
			get {
				return _ssIso;
			}
			set {
				if ((_ssIso!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssIso = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 80, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PrintableName", 80, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("PrintableName")]
		private string _ssPrintableName;
		public string ssPrintableName {
			get {
				return _ssPrintableName;
			}
			set {
				if ((_ssPrintableName!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssPrintableName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Iso3", 3, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Iso3")]
		private string _ssIso3;
		public string ssIso3 {
			get {
				return _ssIso3;
			}
			set {
				if ((_ssIso3!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssIso3 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, true, false, true)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[4]) {
					ChangedAttributes = new BitArray(5, true);
					_ssCountryId = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDCountryEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssIso = "";
			_ssName = "";
			_ssPrintableName = "";
			_ssIso3 = "";
			_ssCountryId = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssIso = r.ReadText(index++, "t_MDCountry.Iso", "");
			ssName = r.ReadText(index++, "t_MDCountry.Name", "");
			ssPrintableName = r.ReadText(index++, "t_MDCountry.PrintableName", "");
			ssIso3 = r.ReadText(index++, "t_MDCountry.Iso3", "");
			ssCountryId = r.ReadInteger(index++, "t_MDCountry.CountryId", 0);
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDCountryEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDCountryEntityRecord a, ENt_MDCountryEntityRecord b) {
			if (a.ssIso != b.ssIso) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssPrintableName != b.ssPrintableName) return false;
			if (a.ssIso3 != b.ssIso3) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			return true;
		}

		public static bool operator != (ENt_MDCountryEntityRecord a, ENt_MDCountryEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDCountryEntityRecord)) return false;
			return (this == (ENt_MDCountryEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssIso.GetHashCode()
				^ ssName.GetHashCode()
				^ ssPrintableName.GetHashCode()
				^ ssIso3.GetHashCode()
				^ ssCountryId.GetHashCode()
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

		public ENt_MDCountryEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssIso = "";
			_ssName = "";
			_ssPrintableName = "";
			_ssIso3 = "";
			_ssCountryId = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssIso", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIso' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIso = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssPrintableName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPrintableName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPrintableName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssIso3", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssIso3' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssIso3 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDCountryEntityRecord Duplicate() {
			ENt_MDCountryEntityRecord t;
			t._ssIso = this._ssIso;
			t._ssName = this._ssName;
			t._ssPrintableName = this._ssPrintableName;
			t._ssIso3 = this._ssIso3;
			t._ssCountryId = this._ssCountryId;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Iso")) VarValue.AppendAttribute(recordElem, "Iso", ssIso, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Iso");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PrintableName")) VarValue.AppendAttribute(recordElem, "PrintableName", ssPrintableName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "PrintableName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Iso3")) VarValue.AppendAttribute(recordElem, "Iso3", ssIso3, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Iso3");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "iso") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Iso")) variable.Value = ssIso; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "printablename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PrintableName")) variable.Value = ssPrintableName; else variable.Optimized = true;
			} else if (head == "iso3") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Iso3")) variable.Value = ssIso3; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdIso)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdPrintableName)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdIso3)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdIso)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdPrintableName)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdIso3)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIso) {
				return ssIso;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdPrintableName) {
				return ssPrintableName;
			} else if (key == IdIso3) {
				return ssIso3;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssIso = (string) other.AttributeGet(IdIso);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdIso);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdIso);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssPrintableName = (string) other.AttributeGet(IdPrintableName);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdPrintableName);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdPrintableName);
			ssIso3 = (string) other.AttributeGet(IdIso3);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdIso3);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIso3);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCountryId);
		}
		public bool IsDefault() {
			ENt_MDCountryEntityRecord defaultStruct = new ENt_MDCountryEntityRecord(null);
			if (this.ssIso != defaultStruct.ssIso) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssPrintableName != defaultStruct.ssPrintableName) return false;
			if (this.ssIso3 != defaultStruct.ssIso3) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			return true;
		}
	} // ENt_MDCountryEntityRecord

	public sealed partial class ENt_MDEventEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDEvent]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "eventtypeid", "EventTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDEventEntity

	/// <summary>
	/// Entity <code>ENt_MDEventEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDEvent</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDEvent", "RCt7vhJa4kqsKvdDTvLWJg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDEvent]", null)]
	[Serializable()]
	public partial struct ENt_MDEventEntityRecord: ISerializable, ITypedRecord<ENt_MDEventEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdEventTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*4MVv0o6UoESbXAaMN5E+sg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*YeQZ9Gor80CTfTMVsrv2kA");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*6yd+qmPnx0CeNTU8RuwL0g");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ImQfvfuack66kjQ4KSta9A");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*yLUh5n3i6U+p2zsicPgdOw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EventTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("EventTypeId")]
		private int _ssEventTypeId;
		public int ssEventTypeId {
			get {
				return _ssEventTypeId;
			}
			set {
				if ((_ssEventTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssEventTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDEventEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssEventTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssEventTypeId = r.ReadInteger(index++, "t_MDEvent.EventTypeId", 0);
			ssName = r.ReadText(index++, "t_MDEvent.Name", "");
			ssDescription = r.ReadText(index++, "t_MDEvent.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDEvent.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDEvent.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDEventEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDEventEntityRecord a, ENt_MDEventEntityRecord b) {
			if (a.ssEventTypeId != b.ssEventTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDEventEntityRecord a, ENt_MDEventEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDEventEntityRecord)) return false;
			return (this == (ENt_MDEventEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEventTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDEventEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssEventTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssEventTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEventTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEventTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDEventEntityRecord Duplicate() {
			ENt_MDEventEntityRecord t;
			t._ssEventTypeId = this._ssEventTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EventTypeId")) VarValue.AppendAttribute(recordElem, "EventTypeId", ssEventTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "EventTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "eventtypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EventTypeId")) variable.Value = ssEventTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEventTypeId) {
				return ssEventTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssEventTypeId = (int) other.AttributeGet(IdEventTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdEventTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdEventTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDEventEntityRecord defaultStruct = new ENt_MDEventEntityRecord(null);
			if (this.ssEventTypeId != defaultStruct.ssEventTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDEventEntityRecord

	public sealed partial class ENt_MUAlbumEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUAlbum]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "albumid", "AlbumId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "releasedate", "ReleaseDate"
				}
				, { "unitssold", "UnitsSold"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUAlbumEntity

	/// <summary>
	/// Entity <code>ENt_MUAlbumEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUAlbum</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUAlbum", "rJRqwtKKcEyzOpDFVo0Sgg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUAlbum]", null)]
	[Serializable()]
	public partial struct ENt_MUAlbumEntityRecord: ISerializable, ITypedRecord<ENt_MUAlbumEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdAlbumId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*+yieiAynQkGXQ_F51R+OfQ");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*vPJboMid0kK6OufnwUzoXA");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*9lALfbHZV0y1Bq0uelGOJA");
		private static readonly GlobalObjectKey IdReleaseDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*74cO9MFGXUadX+8BujttRA");
		private static readonly GlobalObjectKey IdUnitsSold = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*FEB3fBn0rEqf7BDmEZtJTA");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Wh2fC+D5MkycmUPBV17odQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*gIU6f1wJZEeNkptupxSx8w");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AlbumId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("AlbumId")]
		private int _ssAlbumId;
		public int ssAlbumId {
			get {
				return _ssAlbumId;
			}
			set {
				if ((_ssAlbumId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(7, true);
					_ssAlbumId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 500, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 2000, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ReleaseDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("ReleaseDate")]
		private DateTime _ssReleaseDate;
		public DateTime ssReleaseDate {
			get {
				return _ssReleaseDate;
			}
			set {
				if ((_ssReleaseDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssReleaseDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UnitsSold", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UnitsSold")]
		private long _ssUnitsSold;
		public long ssUnitsSold {
			get {
				return _ssUnitsSold;
			}
			set {
				if ((_ssUnitsSold!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUnitsSold = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUAlbumEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssAlbumId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUnitsSold = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAlbumId = r.ReadInteger(index++, "t_MUAlbum.AlbumId", 0);
			ssName = r.ReadText(index++, "t_MUAlbum.Name", "");
			ssDescription = r.ReadText(index++, "t_MUAlbum.Description", "");
			ssReleaseDate = r.ReadDate(index++, "t_MUAlbum.ReleaseDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUnitsSold = r.ReadLongInteger(index++, "t_MUAlbum.UnitsSold", 0L);
			ssInsertDate = r.ReadDateTime(index++, "t_MUAlbum.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUAlbum.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(7, false);
			OptimizedAttributes = new BitArray(7, false);
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
		public void ReadIM(ENt_MUAlbumEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUAlbumEntityRecord a, ENt_MUAlbumEntityRecord b) {
			if (a.ssAlbumId != b.ssAlbumId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssReleaseDate != b.ssReleaseDate) return false;
			if (a.ssUnitsSold != b.ssUnitsSold) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUAlbumEntityRecord a, ENt_MUAlbumEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUAlbumEntityRecord)) return false;
			return (this == (ENt_MUAlbumEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAlbumId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssReleaseDate.GetHashCode()
				^ ssUnitsSold.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUAlbumEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssAlbumId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssReleaseDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUnitsSold = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssAlbumId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAlbumId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAlbumId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssReleaseDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssReleaseDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssReleaseDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUnitsSold", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUnitsSold' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUnitsSold = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUAlbumEntityRecord Duplicate() {
			ENt_MUAlbumEntityRecord t;
			t._ssAlbumId = this._ssAlbumId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssReleaseDate = this._ssReleaseDate;
			t._ssUnitsSold = this._ssUnitsSold;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(7);
			t.OptimizedAttributes = new BitArray(7);
			for (int i = 0; i < 7; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AlbumId")) VarValue.AppendAttribute(recordElem, "AlbumId", ssAlbumId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "AlbumId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ReleaseDate")) VarValue.AppendAttribute(recordElem, "ReleaseDate", ssReleaseDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "ReleaseDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UnitsSold")) VarValue.AppendAttribute(recordElem, "UnitsSold", ssUnitsSold, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "UnitsSold");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "albumid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AlbumId")) variable.Value = ssAlbumId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "releasedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReleaseDate")) variable.Value = ssReleaseDate; else variable.Optimized = true;
			} else if (head == "unitssold") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UnitsSold")) variable.Value = ssUnitsSold; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAlbumId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdReleaseDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUnitsSold)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdAlbumId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdReleaseDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUnitsSold)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAlbumId) {
				return ssAlbumId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdReleaseDate) {
				return ssReleaseDate;
			} else if (key == IdUnitsSold) {
				return ssUnitsSold;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(7);
			OptimizedAttributes = new BitArray(7);
			if (other == null) return;
			ssAlbumId = (int) other.AttributeGet(IdAlbumId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdAlbumId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdAlbumId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssReleaseDate = (DateTime) other.AttributeGet(IdReleaseDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdReleaseDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdReleaseDate);
			ssUnitsSold = (long) other.AttributeGet(IdUnitsSold);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUnitsSold);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUnitsSold);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUAlbumEntityRecord defaultStruct = new ENt_MUAlbumEntityRecord(null);
			if (this.ssAlbumId != defaultStruct.ssAlbumId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssReleaseDate != defaultStruct.ssReleaseDate) return false;
			if (this.ssUnitsSold != defaultStruct.ssUnitsSold) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUAlbumEntityRecord

	public sealed partial class ENt_MUArtistEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtist]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid", "ArtistId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtist</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtist", "kJWXccx3x02bMQCMUe3JJw", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtist]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*d3MEa0pVA0ORt55AifwlDg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*iaXxamRnXUSlZJllvfC3VQ");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0+fpHktCdUa74mBkRfEZaw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*tBi6ksEO+UiZkD4MMqgF0w");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*DMukAEGwQE+mvpE1OqkeVg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 500, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 1073741823, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId = r.ReadInteger(index++, "t_MUArtist.ArtistId", 0);
			ssName = r.ReadText(index++, "t_MUArtist.Name", "");
			ssDescription = r.ReadText(index++, "t_MUArtist.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtist.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUArtist.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MUArtistEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistEntityRecord a, ENt_MUArtistEntityRecord b) {
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistEntityRecord a, ENt_MUArtistEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistEntityRecord)) return false;
			return (this == (ENt_MUArtistEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistEntityRecord Duplicate() {
			ENt_MUArtistEntityRecord t;
			t._ssArtistId = this._ssArtistId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistEntityRecord defaultStruct = new ENt_MUArtistEntityRecord(null);
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistEntityRecord

	public sealed partial class ENt_VNVenueEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_VNVenue]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "venueid", "VenueId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "countryid", "CountryId"
				}
				, { "city", "City"
				}
				, { "address1", "Address1"
				}
				, { "address2", "Address2"
				}
				, { "latitude", "Latitude"
				}
				, { "longitude", "Longitude"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_VNVenueEntity

	/// <summary>
	/// Entity <code>ENt_VNVenueEntityRecord</code> that represents the Service Studio entity
	///  <code>t_VNVenue</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_VNVenue", "b_trf52gz0ikNs7_GYS7Ww", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_VNVenue]", null)]
	[Serializable()]
	public partial struct ENt_VNVenueEntityRecord: ISerializable, ITypedRecord<ENt_VNVenueEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdVenueId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fCFHYMIWJ0+9voesc+M7Mg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*v0UyGCkZ4kKTg4ijlXzraA");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*+7pxIfkq+UGlVRhEvLvtsg");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*T3Q_JAsYcEO3czLS7VlajA");
		private static readonly GlobalObjectKey IdCity = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*8JIGuIMzDUWWwwAVaYKduw");
		private static readonly GlobalObjectKey IdAddress1 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*KYABMwNx_0Gf60SZDg_QnA");
		private static readonly GlobalObjectKey IdAddress2 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Q_j8BzqHfU29hHd4AXYjzA");
		private static readonly GlobalObjectKey IdLatitude = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*_pQwralPikS5jbEHtKmjSw");
		private static readonly GlobalObjectKey IdLongitude = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*zlROBmGeOEC_jC9hhfMQPg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*X_F8zrG0_UiYTMNLW01knw");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*iMSgNO8QBEagvT4Q+eRdRA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("VenueId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("VenueId")]
		private long _ssVenueId;
		public long ssVenueId {
			get {
				return _ssVenueId;
			}
			set {
				if ((_ssVenueId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(11, true);
					_ssVenueId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 100, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssCountryId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("City", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("City")]
		private string _ssCity;
		public string ssCity {
			get {
				return _ssCity;
			}
			set {
				if ((_ssCity!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssCity = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Address1", 200, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Address1")]
		private string _ssAddress1;
		public string ssAddress1 {
			get {
				return _ssAddress1;
			}
			set {
				if ((_ssAddress1!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssAddress1 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Address2", 200, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Address2")]
		private string _ssAddress2;
		public string ssAddress2 {
			get {
				return _ssAddress2;
			}
			set {
				if ((_ssAddress2!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssAddress2 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Latitude", 10, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Latitude")]
		private decimal _ssLatitude;
		public decimal ssLatitude {
			get {
				return _ssLatitude;
			}
			set {
				if ((_ssLatitude!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssLatitude = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Longitude", 10, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Longitude")]
		private decimal _ssLongitude;
		public decimal ssLongitude {
			get {
				return _ssLongitude;
			}
			set {
				if ((_ssLongitude!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssLongitude = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[9]) {
					ChangedAttributes[9] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[10]) {
					ChangedAttributes[10] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_VNVenueEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(11, true);
			OptimizedAttributes = new BitArray(11, false);
			_ssVenueId = 0L;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssCity = "";
			_ssAddress1 = "";
			_ssAddress2 = "";
			_ssLatitude = 0.0M;
			_ssLongitude = 0.0M;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssVenueId = r.ReadLongInteger(index++, "t_VNVenue.VenueId", 0L);
			ssName = r.ReadText(index++, "t_VNVenue.Name", "");
			ssDescription = r.ReadText(index++, "t_VNVenue.Description", "");
			ssCountryId = r.ReadEntityReference(index++, "t_VNVenue.CountryId", 0);
			ssCity = r.ReadText(index++, "t_VNVenue.City", "");
			ssAddress1 = r.ReadText(index++, "t_VNVenue.Address1", "");
			ssAddress2 = r.ReadText(index++, "t_VNVenue.Address2", "");
			ssLatitude = r.ReadDecimal(index++, "t_VNVenue.Latitude", 0.0M);
			ssLongitude = r.ReadDecimal(index++, "t_VNVenue.Longitude", 0.0M);
			ssInsertDate = r.ReadDateTime(index++, "t_VNVenue.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_VNVenue.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(11, false);
			OptimizedAttributes = new BitArray(11, false);
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
		public void ReadIM(ENt_VNVenueEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_VNVenueEntityRecord a, ENt_VNVenueEntityRecord b) {
			if (a.ssVenueId != b.ssVenueId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			if (a.ssCity != b.ssCity) return false;
			if (a.ssAddress1 != b.ssAddress1) return false;
			if (a.ssAddress2 != b.ssAddress2) return false;
			if (a.ssLatitude != b.ssLatitude) return false;
			if (a.ssLongitude != b.ssLongitude) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_VNVenueEntityRecord a, ENt_VNVenueEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_VNVenueEntityRecord)) return false;
			return (this == (ENt_VNVenueEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssVenueId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssCountryId.GetHashCode()
				^ ssCity.GetHashCode()
				^ ssAddress1.GetHashCode()
				^ ssAddress2.GetHashCode()
				^ ssLatitude.GetHashCode()
				^ ssLongitude.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_VNVenueEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(11, true);
			OptimizedAttributes = new BitArray(11, false);
			_ssVenueId = 0L;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssCity = "";
			_ssAddress1 = "";
			_ssAddress2 = "";
			_ssLatitude = 0.0M;
			_ssLongitude = 0.0M;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssVenueId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVenueId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVenueId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCity", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCity' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCity = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAddress1", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAddress1' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAddress1 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAddress2", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAddress2' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAddress2 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLatitude", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLatitude' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLatitude = (decimal) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLongitude", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLongitude' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLongitude = (decimal) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_VNVenueEntityRecord Duplicate() {
			ENt_VNVenueEntityRecord t;
			t._ssVenueId = this._ssVenueId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssCountryId = this._ssCountryId;
			t._ssCity = this._ssCity;
			t._ssAddress1 = this._ssAddress1;
			t._ssAddress2 = this._ssAddress2;
			t._ssLatitude = this._ssLatitude;
			t._ssLongitude = this._ssLongitude;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(11);
			t.OptimizedAttributes = new BitArray(11);
			for (int i = 0; i < 11; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.AppendAttribute(recordElem, "VenueId", ssVenueId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "VenueId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".City")) VarValue.AppendAttribute(recordElem, "City", ssCity, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "City");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Address1")) VarValue.AppendAttribute(recordElem, "Address1", ssAddress1, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Address1");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Address2")) VarValue.AppendAttribute(recordElem, "Address2", ssAddress2, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Address2");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Latitude")) VarValue.AppendAttribute(recordElem, "Latitude", ssLatitude, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "Latitude");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Longitude")) VarValue.AppendAttribute(recordElem, "Longitude", ssLongitude, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "Longitude");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "venueid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".VenueId")) variable.Value = ssVenueId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			} else if (head == "city") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".City")) variable.Value = ssCity; else variable.Optimized = true;
			} else if (head == "address1") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Address1")) variable.Value = ssAddress1; else variable.Optimized = true;
			} else if (head == "address2") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Address2")) variable.Value = ssAddress2; else variable.Optimized = true;
			} else if (head == "latitude") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Latitude")) variable.Value = ssLatitude; else variable.Optimized = true;
			} else if (head == "longitude") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Longitude")) variable.Value = ssLongitude; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdVenueId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdCity)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdAddress1)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdAddress2)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdLatitude)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdLongitude)) {
				return ChangedAttributes[8];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[9];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[10];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdVenueId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdCity)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdAddress1)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdAddress2)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdLatitude)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdLongitude)) {
				return OptimizedAttributes[8];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[9];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[10];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdVenueId) {
				return ssVenueId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else if (key == IdCity) {
				return ssCity;
			} else if (key == IdAddress1) {
				return ssAddress1;
			} else if (key == IdAddress2) {
				return ssAddress2;
			} else if (key == IdLatitude) {
				return ssLatitude;
			} else if (key == IdLongitude) {
				return ssLongitude;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(11);
			OptimizedAttributes = new BitArray(11);
			if (other == null) return;
			ssVenueId = (long) other.AttributeGet(IdVenueId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdVenueId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdVenueId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCountryId);
			ssCity = (string) other.AttributeGet(IdCity);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdCity);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCity);
			ssAddress1 = (string) other.AttributeGet(IdAddress1);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdAddress1);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdAddress1);
			ssAddress2 = (string) other.AttributeGet(IdAddress2);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdAddress2);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdAddress2);
			ssLatitude = (decimal) other.AttributeGet(IdLatitude);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdLatitude);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdLatitude);
			ssLongitude = (decimal) other.AttributeGet(IdLongitude);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdLongitude);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdLongitude);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[9] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[9] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[10] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[10] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_VNVenueEntityRecord defaultStruct = new ENt_VNVenueEntityRecord(null);
			if (this.ssVenueId != defaultStruct.ssVenueId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			if (this.ssCity != defaultStruct.ssCity) return false;
			if (this.ssAddress1 != defaultStruct.ssAddress1) return false;
			if (this.ssAddress2 != defaultStruct.ssAddress2) return false;
			if (this.ssLatitude != defaultStruct.ssLatitude) return false;
			if (this.ssLongitude != defaultStruct.ssLongitude) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_VNVenueEntityRecord

	public sealed partial class ENt_MDDataPointEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDDataPoint]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "datapointtypeid", "DatapointTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDDataPointEntity

	/// <summary>
	/// Entity <code>ENt_MDDataPointEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDDataPoint</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDDataPoint", "i2AUQ0CmbEy1RQXMJKX2Xg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDDataPoint]", null)]
	[Serializable()]
	public partial struct ENt_MDDataPointEntityRecord: ISerializable, ITypedRecord<ENt_MDDataPointEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdDatapointTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JMXQoS+XwESGkkfEvL3TSA");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*lBZu9ZALIEqyTmLVmwMRcQ");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*YLRRJ1C0GEKpzbVeW36rTQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JdfMqeI4Y0WgGripKzsNFQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*sCNbnadlx0yDeyJqA6ZfXg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DatapointTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("DatapointTypeId")]
		private int _ssDatapointTypeId;
		public int ssDatapointTypeId {
			get {
				return _ssDatapointTypeId;
			}
			set {
				if ((_ssDatapointTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssDatapointTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDDataPointEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssDatapointTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDatapointTypeId = r.ReadInteger(index++, "t_MDDataPoint.DatapointTypeId", 0);
			ssName = r.ReadText(index++, "t_MDDataPoint.Name", "");
			ssDescription = r.ReadText(index++, "t_MDDataPoint.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDDataPoint.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDDataPoint.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDDataPointEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDDataPointEntityRecord a, ENt_MDDataPointEntityRecord b) {
			if (a.ssDatapointTypeId != b.ssDatapointTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDDataPointEntityRecord a, ENt_MDDataPointEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDDataPointEntityRecord)) return false;
			return (this == (ENt_MDDataPointEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDatapointTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDDataPointEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssDatapointTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssDatapointTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDatapointTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDatapointTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDDataPointEntityRecord Duplicate() {
			ENt_MDDataPointEntityRecord t;
			t._ssDatapointTypeId = this._ssDatapointTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DatapointTypeId")) VarValue.AppendAttribute(recordElem, "DatapointTypeId", ssDatapointTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "DatapointTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datapointtypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DatapointTypeId")) variable.Value = ssDatapointTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDatapointTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDatapointTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDatapointTypeId) {
				return ssDatapointTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssDatapointTypeId = (int) other.AttributeGet(IdDatapointTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdDatapointTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDatapointTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDDataPointEntityRecord defaultStruct = new ENt_MDDataPointEntityRecord(null);
			if (this.ssDatapointTypeId != defaultStruct.ssDatapointTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDDataPointEntityRecord

	public sealed partial class ENt_MUArtistSocialMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistSocialMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid", "ArtistId"
				}
				, { "socialmediaid", "SocialMediaId"
				}
				, { "link", "Link"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistSocialMediaEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistSocialMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistSocialMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistSocialMedia", "IsbBJL2dfEWccGYyGf2dKA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistSocialMedia]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistSocialMediaEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistSocialMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*D0qF9tyQ7kOYwRLQBdD4LA");
		private static readonly GlobalObjectKey IdSocialMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*1b2lhK1dmUOuyJRmllD6LA");
		private static readonly GlobalObjectKey IdLink = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ewuY9+reKEmqJyCb7t4a_w");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*NPjxCoO9DkyqxKMeQobEQQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*gSSMubsnqU+_3yW5yu3Wiw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SocialMediaId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("SocialMediaId")]
		private int _ssSocialMediaId;
		public int ssSocialMediaId {
			get {
				return _ssSocialMediaId;
			}
			set {
				if ((_ssSocialMediaId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssSocialMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Link", 5000, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Link")]
		private string _ssLink;
		public string ssLink {
			get {
				return _ssLink;
			}
			set {
				if ((_ssLink!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssLink = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistSocialMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssSocialMediaId = 0;
			_ssLink = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistSocialMedia.ArtistId", 0);
			ssSocialMediaId = r.ReadEntityReference(index++, "t_MUArtistSocialMedia.SocialMediaId", 0);
			ssLink = r.ReadText(index++, "t_MUArtistSocialMedia.Link", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistSocialMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUArtistSocialMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MUArtistSocialMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistSocialMediaEntityRecord a, ENt_MUArtistSocialMediaEntityRecord b) {
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssSocialMediaId != b.ssSocialMediaId) return false;
			if (a.ssLink != b.ssLink) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistSocialMediaEntityRecord a, ENt_MUArtistSocialMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistSocialMediaEntityRecord)) return false;
			return (this == (ENt_MUArtistSocialMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssSocialMediaId.GetHashCode()
				^ ssLink.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistSocialMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssSocialMediaId = 0;
			_ssLink = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssSocialMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSocialMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSocialMediaId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLink", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLink' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLink = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistSocialMediaEntityRecord Duplicate() {
			ENt_MUArtistSocialMediaEntityRecord t;
			t._ssArtistId = this._ssArtistId;
			t._ssSocialMediaId = this._ssSocialMediaId;
			t._ssLink = this._ssLink;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.AppendAttribute(recordElem, "SocialMediaId", ssSocialMediaId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "SocialMediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Link")) VarValue.AppendAttribute(recordElem, "Link", ssLink, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Link");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "socialmediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.Value = ssSocialMediaId; else variable.Optimized = true;
			} else if (head == "link") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Link")) variable.Value = ssLink; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdSocialMediaId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdLink)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdSocialMediaId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdLink)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdSocialMediaId) {
				return ssSocialMediaId;
			} else if (key == IdLink) {
				return ssLink;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId);
			ssSocialMediaId = (int) other.AttributeGet(IdSocialMediaId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdSocialMediaId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdSocialMediaId);
			ssLink = (string) other.AttributeGet(IdLink);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdLink);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLink);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistSocialMediaEntityRecord defaultStruct = new ENt_MUArtistSocialMediaEntityRecord(null);
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssSocialMediaId != defaultStruct.ssSocialMediaId) return false;
			if (this.ssLink != defaultStruct.ssLink) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistSocialMediaEntityRecord

	public sealed partial class ENt_MDSocialMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDSocialMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "socialmediaid", "SocialMediaId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDSocialMediaEntity

	/// <summary>
	/// Entity <code>ENt_MDSocialMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDSocialMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDSocialMedia", "o2TKnjx09UyJpCE2MIgQzg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDSocialMedia]", null)]
	[Serializable()]
	public partial struct ENt_MDSocialMediaEntityRecord: ISerializable, ITypedRecord<ENt_MDSocialMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdSocialMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*jnk3F8RBl0qqyS_ePPmONg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Q0Eg4nCdKkijWwqmlaTAgw");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*5rpY1g2og0KlQcsYKtqXIA");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*FWjLdxdPZ0ic0PD2va8d8w");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*FLy5nJ+eMkyKQpw4pk3wjQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SocialMediaId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("SocialMediaId")]
		private int _ssSocialMediaId;
		public int ssSocialMediaId {
			get {
				return _ssSocialMediaId;
			}
			set {
				if ((_ssSocialMediaId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssSocialMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDSocialMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssSocialMediaId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSocialMediaId = r.ReadInteger(index++, "t_MDSocialMedia.SocialMediaId", 0);
			ssName = r.ReadText(index++, "t_MDSocialMedia.Name", "");
			ssDescription = r.ReadText(index++, "t_MDSocialMedia.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDSocialMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDSocialMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDSocialMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDSocialMediaEntityRecord a, ENt_MDSocialMediaEntityRecord b) {
			if (a.ssSocialMediaId != b.ssSocialMediaId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDSocialMediaEntityRecord a, ENt_MDSocialMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDSocialMediaEntityRecord)) return false;
			return (this == (ENt_MDSocialMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSocialMediaId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDSocialMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssSocialMediaId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssSocialMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSocialMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSocialMediaId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDSocialMediaEntityRecord Duplicate() {
			ENt_MDSocialMediaEntityRecord t;
			t._ssSocialMediaId = this._ssSocialMediaId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.AppendAttribute(recordElem, "SocialMediaId", ssSocialMediaId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "SocialMediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "socialmediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.Value = ssSocialMediaId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdSocialMediaId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdSocialMediaId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdSocialMediaId) {
				return ssSocialMediaId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssSocialMediaId = (int) other.AttributeGet(IdSocialMediaId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdSocialMediaId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSocialMediaId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDSocialMediaEntityRecord defaultStruct = new ENt_MDSocialMediaEntityRecord(null);
			if (this.ssSocialMediaId != defaultStruct.ssSocialMediaId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDSocialMediaEntityRecord

	public sealed partial class ENt_SMArtistDataPointEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_SMArtistDataPoint]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "datapointid", "DataPointId"
				}
				, { "artistid", "ArtistId"
				}
				, { "socialmediaid", "SocialMediaId"
				}
				, { "datapointtypeid", "DataPointTypeId"
				}
				, { "datapoint", "Datapoint"
				}
				, { "countryid", "CountryId"
				}
				, { "referencedate", "ReferenceDate"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_SMArtistDataPointEntity

	/// <summary>
	/// Entity <code>ENt_SMArtistDataPointEntityRecord</code> that represents the Service Studio entity
	///  <code>t_SMArtistDataPoint</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_SMArtistDataPoint", "ItWSFiRyykqtYZx2qDHWmg", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_SMArtistDataPoint]", null)]
	[Serializable()]
	public partial struct ENt_SMArtistDataPointEntityRecord: ISerializable, ITypedRecord<ENt_SMArtistDataPointEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdDataPointId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JR9XVW899Ea4DDjMHtPW3A");
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*2rlCqOp3_UuV7VEo_nb2kA");
		private static readonly GlobalObjectKey IdSocialMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*j6fyeh75x0+UXAYfhKwWxg");
		private static readonly GlobalObjectKey IdDataPointTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*aoSLL1yS9E67XNKgKpgpsQ");
		private static readonly GlobalObjectKey IdDatapoint = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*qAyhF13rlESRD_e8LdpfxA");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*z+QYh_wcJkyNTvWE+_ibBQ");
		private static readonly GlobalObjectKey IdReferenceDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*3Ypwk4op9EedWZyAtk6RCg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*m3ScJm5_DU6vYUWsOGbUwg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*A7Q2+417f0OvdBbtH_t0xQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataPointId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("DataPointId")]
		private long _ssDataPointId;
		public long ssDataPointId {
			get {
				return _ssDataPointId;
			}
			set {
				if ((_ssDataPointId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(9, true);
					_ssDataPointId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SocialMediaId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("SocialMediaId")]
		private int _ssSocialMediaId;
		public int ssSocialMediaId {
			get {
				return _ssSocialMediaId;
			}
			set {
				if ((_ssSocialMediaId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssSocialMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataPointTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("DataPointTypeId")]
		private int _ssDataPointTypeId;
		public int ssDataPointTypeId {
			get {
				return _ssDataPointTypeId;
			}
			set {
				if ((_ssDataPointTypeId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssDataPointTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Datapoint", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Datapoint")]
		private long _ssDatapoint;
		public long ssDatapoint {
			get {
				return _ssDatapoint;
			}
			set {
				if ((_ssDatapoint!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssDatapoint = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCountryId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ReferenceDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("ReferenceDate")]
		private DateTime _ssReferenceDate;
		public DateTime ssReferenceDate {
			get {
				return _ssReferenceDate;
			}
			set {
				if ((_ssReferenceDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssReferenceDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_SMArtistDataPointEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(9, true);
			OptimizedAttributes = new BitArray(9, false);
			_ssDataPointId = 0L;
			_ssArtistId = 0;
			_ssSocialMediaId = 0;
			_ssDataPointTypeId = 0;
			_ssDatapoint = 0L;
			_ssCountryId = 0;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDataPointId = r.ReadLongInteger(index++, "t_SMArtistDataPoint.DataPointId", 0L);
			ssArtistId = r.ReadEntityReference(index++, "t_SMArtistDataPoint.ArtistId", 0);
			ssSocialMediaId = r.ReadEntityReference(index++, "t_SMArtistDataPoint.SocialMediaId", 0);
			ssDataPointTypeId = r.ReadEntityReference(index++, "t_SMArtistDataPoint.DataPointTypeId", 0);
			ssDatapoint = r.ReadLongInteger(index++, "t_SMArtistDataPoint.Datapoint", 0L);
			ssCountryId = r.ReadEntityReference(index++, "t_SMArtistDataPoint.CountryId", 0);
			ssReferenceDate = r.ReadDate(index++, "t_SMArtistDataPoint.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssInsertDate = r.ReadDateTime(index++, "t_SMArtistDataPoint.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_SMArtistDataPoint.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(9, false);
			OptimizedAttributes = new BitArray(9, false);
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
		public void ReadIM(ENt_SMArtistDataPointEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_SMArtistDataPointEntityRecord a, ENt_SMArtistDataPointEntityRecord b) {
			if (a.ssDataPointId != b.ssDataPointId) return false;
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssSocialMediaId != b.ssSocialMediaId) return false;
			if (a.ssDataPointTypeId != b.ssDataPointTypeId) return false;
			if (a.ssDatapoint != b.ssDatapoint) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			if (a.ssReferenceDate != b.ssReferenceDate) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_SMArtistDataPointEntityRecord a, ENt_SMArtistDataPointEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_SMArtistDataPointEntityRecord)) return false;
			return (this == (ENt_SMArtistDataPointEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDataPointId.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssSocialMediaId.GetHashCode()
				^ ssDataPointTypeId.GetHashCode()
				^ ssDatapoint.GetHashCode()
				^ ssCountryId.GetHashCode()
				^ ssReferenceDate.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_SMArtistDataPointEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(9, true);
			OptimizedAttributes = new BitArray(9, false);
			_ssDataPointId = 0L;
			_ssArtistId = 0;
			_ssSocialMediaId = 0;
			_ssDataPointTypeId = 0;
			_ssDatapoint = 0L;
			_ssCountryId = 0;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssDataPointId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataPointId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataPointId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssSocialMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSocialMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSocialMediaId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDataPointTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataPointTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataPointTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDatapoint", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDatapoint' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDatapoint = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssReferenceDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssReferenceDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssReferenceDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_SMArtistDataPointEntityRecord Duplicate() {
			ENt_SMArtistDataPointEntityRecord t;
			t._ssDataPointId = this._ssDataPointId;
			t._ssArtistId = this._ssArtistId;
			t._ssSocialMediaId = this._ssSocialMediaId;
			t._ssDataPointTypeId = this._ssDataPointTypeId;
			t._ssDatapoint = this._ssDatapoint;
			t._ssCountryId = this._ssCountryId;
			t._ssReferenceDate = this._ssReferenceDate;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(9);
			t.OptimizedAttributes = new BitArray(9);
			for (int i = 0; i < 9; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataPointId")) VarValue.AppendAttribute(recordElem, "DataPointId", ssDataPointId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataPointId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.AppendAttribute(recordElem, "SocialMediaId", ssSocialMediaId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "SocialMediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataPointTypeId")) VarValue.AppendAttribute(recordElem, "DataPointTypeId", ssDataPointTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "DataPointTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Datapoint")) VarValue.AppendAttribute(recordElem, "Datapoint", ssDatapoint, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "Datapoint");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ReferenceDate")) VarValue.AppendAttribute(recordElem, "ReferenceDate", ssReferenceDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "ReferenceDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datapointid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataPointId")) variable.Value = ssDataPointId; else variable.Optimized = true;
			} else if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "socialmediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.Value = ssSocialMediaId; else variable.Optimized = true;
			} else if (head == "datapointtypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataPointTypeId")) variable.Value = ssDataPointTypeId; else variable.Optimized = true;
			} else if (head == "datapoint") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Datapoint")) variable.Value = ssDatapoint; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			} else if (head == "referencedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceDate")) variable.Value = ssReferenceDate; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataPointId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdSocialMediaId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdDataPointTypeId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdDatapoint)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdReferenceDate)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[8];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataPointId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdSocialMediaId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdDataPointTypeId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdDatapoint)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdReferenceDate)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[8];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDataPointId) {
				return ssDataPointId;
			} else if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdSocialMediaId) {
				return ssSocialMediaId;
			} else if (key == IdDataPointTypeId) {
				return ssDataPointTypeId;
			} else if (key == IdDatapoint) {
				return ssDatapoint;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else if (key == IdReferenceDate) {
				return ssReferenceDate;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(9);
			OptimizedAttributes = new BitArray(9);
			if (other == null) return;
			ssDataPointId = (long) other.AttributeGet(IdDataPointId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdDataPointId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDataPointId);
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdArtistId);
			ssSocialMediaId = (int) other.AttributeGet(IdSocialMediaId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdSocialMediaId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdSocialMediaId);
			ssDataPointTypeId = (int) other.AttributeGet(IdDataPointTypeId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdDataPointTypeId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDataPointTypeId);
			ssDatapoint = (long) other.AttributeGet(IdDatapoint);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdDatapoint);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdDatapoint);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCountryId);
			ssReferenceDate = (DateTime) other.AttributeGet(IdReferenceDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdReferenceDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdReferenceDate);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_SMArtistDataPointEntityRecord defaultStruct = new ENt_SMArtistDataPointEntityRecord(null);
			if (this.ssDataPointId != defaultStruct.ssDataPointId) return false;
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssSocialMediaId != defaultStruct.ssSocialMediaId) return false;
			if (this.ssDataPointTypeId != defaultStruct.ssDataPointTypeId) return false;
			if (this.ssDatapoint != defaultStruct.ssDatapoint) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			if (this.ssReferenceDate != defaultStruct.ssReferenceDate) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_SMArtistDataPointEntityRecord

	public sealed partial class ENt_MUArtistCorrelationEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistCorrelation]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid1", "ArtistId1"
				}
				, { "artistid2", "ArtistId2"
				}
				, { "correlation", "Correlation"
				}
				, { "socialmediaid", "SocialMediaId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistCorrelationEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistCorrelationEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistCorrelation</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistCorrelation", "zcm2usXe90upFf4XTxWCHA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistCorrelation]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistCorrelationEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistCorrelationEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId1 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*AJjBE9SENUSnxRwsWwciow");
		private static readonly GlobalObjectKey IdArtistId2 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*XBf1gOnnWU6SUmMfzulofw");
		private static readonly GlobalObjectKey IdCorrelation = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JSPomWr3iUSA0sj8UYZXjQ");
		private static readonly GlobalObjectKey IdSocialMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*wCt75IMv3ku7PBvtTxNpXQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*9Jy_vLpJ6kKyRoL+VhlSbA");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*y8qQIW14ZE2mCvIIwS9NLw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId1", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId1")]
		private int _ssArtistId1;
		public int ssArtistId1 {
			get {
				return _ssArtistId1;
			}
			set {
				if ((_ssArtistId1!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssArtistId1 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId2", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId2")]
		private int _ssArtistId2;
		public int ssArtistId2 {
			get {
				return _ssArtistId2;
			}
			set {
				if ((_ssArtistId2!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssArtistId2 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Correlation", 18, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Correlation")]
		private decimal _ssCorrelation;
		public decimal ssCorrelation {
			get {
				return _ssCorrelation;
			}
			set {
				if ((_ssCorrelation!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssCorrelation = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("SocialMediaId", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("SocialMediaId")]
		private int _ssSocialMediaId;
		public int ssSocialMediaId {
			get {
				return _ssSocialMediaId;
			}
			set {
				if ((_ssSocialMediaId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssSocialMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistCorrelationEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssArtistId1 = 0;
			_ssArtistId2 = 0;
			_ssCorrelation = 0.0M;
			_ssSocialMediaId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId1 = r.ReadEntityReference(index++, "t_MUArtistCorrelation.ArtistId1", 0);
			ssArtistId2 = r.ReadEntityReference(index++, "t_MUArtistCorrelation.ArtistId2", 0);
			ssCorrelation = r.ReadDecimal(index++, "t_MUArtistCorrelation.Correlation", 0.0M);
			ssSocialMediaId = r.ReadInteger(index++, "t_MUArtistCorrelation.SocialMediaId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistCorrelation.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDate(index++, "t_MUArtistCorrelation.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(6, false);
			OptimizedAttributes = new BitArray(6, false);
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
		public void ReadIM(ENt_MUArtistCorrelationEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistCorrelationEntityRecord a, ENt_MUArtistCorrelationEntityRecord b) {
			if (a.ssArtistId1 != b.ssArtistId1) return false;
			if (a.ssArtistId2 != b.ssArtistId2) return false;
			if (a.ssCorrelation != b.ssCorrelation) return false;
			if (a.ssSocialMediaId != b.ssSocialMediaId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistCorrelationEntityRecord a, ENt_MUArtistCorrelationEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistCorrelationEntityRecord)) return false;
			return (this == (ENt_MUArtistCorrelationEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId1.GetHashCode()
				^ ssArtistId2.GetHashCode()
				^ ssCorrelation.GetHashCode()
				^ ssSocialMediaId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistCorrelationEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssArtistId1 = 0;
			_ssArtistId2 = 0;
			_ssCorrelation = 0.0M;
			_ssSocialMediaId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId1", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId1' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId1 = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssArtistId2", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId2' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId2 = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCorrelation", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCorrelation' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCorrelation = (decimal) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssSocialMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssSocialMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssSocialMediaId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistCorrelationEntityRecord Duplicate() {
			ENt_MUArtistCorrelationEntityRecord t;
			t._ssArtistId1 = this._ssArtistId1;
			t._ssArtistId2 = this._ssArtistId2;
			t._ssCorrelation = this._ssCorrelation;
			t._ssSocialMediaId = this._ssSocialMediaId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(6);
			t.OptimizedAttributes = new BitArray(6);
			for (int i = 0; i < 6; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId1")) VarValue.AppendAttribute(recordElem, "ArtistId1", ssArtistId1, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId1");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId2")) VarValue.AppendAttribute(recordElem, "ArtistId2", ssArtistId2, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId2");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Correlation")) VarValue.AppendAttribute(recordElem, "Correlation", ssCorrelation, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "Correlation");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.AppendAttribute(recordElem, "SocialMediaId", ssSocialMediaId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "SocialMediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid1") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId1")) variable.Value = ssArtistId1; else variable.Optimized = true;
			} else if (head == "artistid2") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId2")) variable.Value = ssArtistId2; else variable.Optimized = true;
			} else if (head == "correlation") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Correlation")) variable.Value = ssCorrelation; else variable.Optimized = true;
			} else if (head == "socialmediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.Value = ssSocialMediaId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId1)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdArtistId2)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdCorrelation)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdSocialMediaId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId1)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdArtistId2)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdCorrelation)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdSocialMediaId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId1) {
				return ssArtistId1;
			} else if (key == IdArtistId2) {
				return ssArtistId2;
			} else if (key == IdCorrelation) {
				return ssCorrelation;
			} else if (key == IdSocialMediaId) {
				return ssSocialMediaId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(6);
			OptimizedAttributes = new BitArray(6);
			if (other == null) return;
			ssArtistId1 = (int) other.AttributeGet(IdArtistId1);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId1);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId1);
			ssArtistId2 = (int) other.AttributeGet(IdArtistId2);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdArtistId2);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdArtistId2);
			ssCorrelation = (decimal) other.AttributeGet(IdCorrelation);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdCorrelation);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdCorrelation);
			ssSocialMediaId = (int) other.AttributeGet(IdSocialMediaId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdSocialMediaId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdSocialMediaId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistCorrelationEntityRecord defaultStruct = new ENt_MUArtistCorrelationEntityRecord(null);
			if (this.ssArtistId1 != defaultStruct.ssArtistId1) return false;
			if (this.ssArtistId2 != defaultStruct.ssArtistId2) return false;
			if (this.ssCorrelation != defaultStruct.ssCorrelation) return false;
			if (this.ssSocialMediaId != defaultStruct.ssSocialMediaId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistCorrelationEntityRecord

	public sealed partial class ENt_MGPromoterEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MGPromoter]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "promoterid", "PromoterId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "countryid", "CountryId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MGPromoterEntity

	/// <summary>
	/// Entity <code>ENt_MGPromoterEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MGPromoter</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MGPromoter", "_OnIB9UNqEuSpJuWFNfZiA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MGPromoter]", null)]
	[Serializable()]
	public partial struct ENt_MGPromoterEntityRecord: ISerializable, ITypedRecord<ENt_MGPromoterEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdPromoterId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*aYcHy9McYUeHQz04Dj7CLg");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*MAB99ZkvZkiK5gN36ERwQw");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*47FcxF8mU0qpSoj0Rwbg4Q");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*C+CYF7_BA02qvi5MnhDXzQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*B3pzWZWxb0GJSko+9AkvSA");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*59a8n0TPv0KpfpyFdRjw0w");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PromoterId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("PromoterId")]
		private int _ssPromoterId;
		public int ssPromoterId {
			get {
				return _ssPromoterId;
			}
			set {
				if ((_ssPromoterId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(6, true);
					_ssPromoterId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 150, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssCountryId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MGPromoterEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssPromoterId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssPromoterId = r.ReadInteger(index++, "t_MGPromoter.PromoterId", 0);
			ssName = r.ReadText(index++, "t_MGPromoter.Name", "");
			ssDescription = r.ReadText(index++, "t_MGPromoter.Description", "");
			ssCountryId = r.ReadEntityReference(index++, "t_MGPromoter.CountryId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MGPromoter.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MGPromoter.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(6, false);
			OptimizedAttributes = new BitArray(6, false);
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
		public void ReadIM(ENt_MGPromoterEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MGPromoterEntityRecord a, ENt_MGPromoterEntityRecord b) {
			if (a.ssPromoterId != b.ssPromoterId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MGPromoterEntityRecord a, ENt_MGPromoterEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MGPromoterEntityRecord)) return false;
			return (this == (ENt_MGPromoterEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssPromoterId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssCountryId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MGPromoterEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssPromoterId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssPromoterId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPromoterId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPromoterId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MGPromoterEntityRecord Duplicate() {
			ENt_MGPromoterEntityRecord t;
			t._ssPromoterId = this._ssPromoterId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssCountryId = this._ssCountryId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(6);
			t.OptimizedAttributes = new BitArray(6);
			for (int i = 0; i < 6; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PromoterId")) VarValue.AppendAttribute(recordElem, "PromoterId", ssPromoterId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "PromoterId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "promoterid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PromoterId")) variable.Value = ssPromoterId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdPromoterId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdPromoterId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdPromoterId) {
				return ssPromoterId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(6);
			OptimizedAttributes = new BitArray(6);
			if (other == null) return;
			ssPromoterId = (int) other.AttributeGet(IdPromoterId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdPromoterId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdPromoterId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCountryId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MGPromoterEntityRecord defaultStruct = new ENt_MGPromoterEntityRecord(null);
			if (this.ssPromoterId != defaultStruct.ssPromoterId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MGPromoterEntityRecord

	public sealed partial class ENt_MDContactEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDContact]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "contacttypeid", "ContactTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDContactEntity

	/// <summary>
	/// Entity <code>ENt_MDContactEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDContact</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDContact", "tRNoSzOAcUGjdxqNFg2k3g", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDContact]", null)]
	[Serializable()]
	public partial struct ENt_MDContactEntityRecord: ISerializable, ITypedRecord<ENt_MDContactEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdContactTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*DD3S9wy7E0SDdf4os3jbdQ");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*sz9wKN2EqE+c+RS5ELoWEg");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*XoAoyWuRVkOwcS6xMjo_5A");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*VsniOK57lUaTRQbUhofGlg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*d84eOr0kWUa_wfr3hQrWJA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("ContactTypeId")]
		private int _ssContactTypeId;
		public int ssContactTypeId {
			get {
				return _ssContactTypeId;
			}
			set {
				if ((_ssContactTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssContactTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDContactEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssContactTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssContactTypeId = r.ReadInteger(index++, "t_MDContact.ContactTypeId", 0);
			ssName = r.ReadText(index++, "t_MDContact.Name", "");
			ssDescription = r.ReadText(index++, "t_MDContact.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDContactEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDContactEntityRecord a, ENt_MDContactEntityRecord b) {
			if (a.ssContactTypeId != b.ssContactTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDContactEntityRecord a, ENt_MDContactEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDContactEntityRecord)) return false;
			return (this == (ENt_MDContactEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssContactTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDContactEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssContactTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssContactTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDContactEntityRecord Duplicate() {
			ENt_MDContactEntityRecord t;
			t._ssContactTypeId = this._ssContactTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactTypeId")) VarValue.AppendAttribute(recordElem, "ContactTypeId", ssContactTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "ContactTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "contacttypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactTypeId")) variable.Value = ssContactTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdContactTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdContactTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdContactTypeId) {
				return ssContactTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssContactTypeId = (int) other.AttributeGet(IdContactTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdContactTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdContactTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDContactEntityRecord defaultStruct = new ENt_MDContactEntityRecord(null);
			if (this.ssContactTypeId != defaultStruct.ssContactTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDContactEntityRecord

	public sealed partial class ENt_CTContactEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_CTContact]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "contactid", "ContactId"
				}
				, { "contacttypeid", "ContactTypeId"
				}
				, { "field1", "Field1"
				}
				, { "field2", "Field2"
				}
				, { "field3", "Field3"
				}
				, { "countryid", "CountryId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_CTContactEntity

	/// <summary>
	/// Entity <code>ENt_CTContactEntityRecord</code> that represents the Service Studio entity
	///  <code>t_CTContact</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_CTContact", "DmdbMH1frE2rkt6rwGK76g", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_CTContact]", null)]
	[Serializable()]
	public partial struct ENt_CTContactEntityRecord: ISerializable, ITypedRecord<ENt_CTContactEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdContactId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ck15wHIdnEqL18RsIwoQug");
		private static readonly GlobalObjectKey IdContactTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*+LhDRkGYvk+yxuG_3Qp8zw");
		private static readonly GlobalObjectKey IdField1 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ruwm8xgrsEeACuFxL6VgCg");
		private static readonly GlobalObjectKey IdField2 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*4ja6Ovz41EeLnQD1O+Q7NA");
		private static readonly GlobalObjectKey IdField3 = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*SuhM14rk6U+GsCrNZr_uCw");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*nqS+7_CPbEy2QgrFq2v9aQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*4ysjB+bDUUWVXTHzZlmaqA");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*c_tYQOs75EaT0v2F607FTQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("ContactId")]
		private long _ssContactId;
		public long ssContactId {
			get {
				return _ssContactId;
			}
			set {
				if ((_ssContactId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(8, true);
					_ssContactId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ContactTypeId")]
		private int _ssContactTypeId;
		public int ssContactTypeId {
			get {
				return _ssContactTypeId;
			}
			set {
				if ((_ssContactTypeId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssContactTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Field1", 500, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Field1")]
		private string _ssField1;
		public string ssField1 {
			get {
				return _ssField1;
			}
			set {
				if ((_ssField1!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssField1 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Field2", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Field2")]
		private string _ssField2;
		public string ssField2 {
			get {
				return _ssField2;
			}
			set {
				if ((_ssField2!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssField2 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Field3", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Field3")]
		private string _ssField3;
		public string ssField3 {
			get {
				return _ssField3;
			}
			set {
				if ((_ssField3!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssField3 = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssCountryId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_CTContactEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssContactId = 0L;
			_ssContactTypeId = 0;
			_ssField1 = "";
			_ssField2 = "";
			_ssField3 = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssContactId = r.ReadLongInteger(index++, "t_CTContact.ContactId", 0L);
			ssContactTypeId = r.ReadEntityReference(index++, "t_CTContact.ContactTypeId", 0);
			ssField1 = r.ReadText(index++, "t_CTContact.Field1", "");
			ssField2 = r.ReadText(index++, "t_CTContact.Field2", "");
			ssField3 = r.ReadText(index++, "t_CTContact.Field3", "");
			ssCountryId = r.ReadEntityReference(index++, "t_CTContact.CountryId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_CTContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_CTContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(8, false);
			OptimizedAttributes = new BitArray(8, false);
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
		public void ReadIM(ENt_CTContactEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_CTContactEntityRecord a, ENt_CTContactEntityRecord b) {
			if (a.ssContactId != b.ssContactId) return false;
			if (a.ssContactTypeId != b.ssContactTypeId) return false;
			if (a.ssField1 != b.ssField1) return false;
			if (a.ssField2 != b.ssField2) return false;
			if (a.ssField3 != b.ssField3) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_CTContactEntityRecord a, ENt_CTContactEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_CTContactEntityRecord)) return false;
			return (this == (ENt_CTContactEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssContactId.GetHashCode()
				^ ssContactTypeId.GetHashCode()
				^ ssField1.GetHashCode()
				^ ssField2.GetHashCode()
				^ ssField3.GetHashCode()
				^ ssCountryId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_CTContactEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(8, true);
			OptimizedAttributes = new BitArray(8, false);
			_ssContactId = 0L;
			_ssContactTypeId = 0;
			_ssField1 = "";
			_ssField2 = "";
			_ssField3 = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssContactId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssContactTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssField1", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssField1' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssField1 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssField2", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssField2' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssField2 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssField3", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssField3' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssField3 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_CTContactEntityRecord Duplicate() {
			ENt_CTContactEntityRecord t;
			t._ssContactId = this._ssContactId;
			t._ssContactTypeId = this._ssContactTypeId;
			t._ssField1 = this._ssField1;
			t._ssField2 = this._ssField2;
			t._ssField3 = this._ssField3;
			t._ssCountryId = this._ssCountryId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(8);
			t.OptimizedAttributes = new BitArray(8);
			for (int i = 0; i < 8; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.AppendAttribute(recordElem, "ContactId", ssContactId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ContactId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactTypeId")) VarValue.AppendAttribute(recordElem, "ContactTypeId", ssContactTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ContactTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Field1")) VarValue.AppendAttribute(recordElem, "Field1", ssField1, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Field1");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Field2")) VarValue.AppendAttribute(recordElem, "Field2", ssField2, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Field2");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Field3")) VarValue.AppendAttribute(recordElem, "Field3", ssField3, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Field3");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "contactid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactId")) variable.Value = ssContactId; else variable.Optimized = true;
			} else if (head == "contacttypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactTypeId")) variable.Value = ssContactTypeId; else variable.Optimized = true;
			} else if (head == "field1") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Field1")) variable.Value = ssField1; else variable.Optimized = true;
			} else if (head == "field2") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Field2")) variable.Value = ssField2; else variable.Optimized = true;
			} else if (head == "field3") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Field3")) variable.Value = ssField3; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdContactId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdContactTypeId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdField1)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdField2)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdField3)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdContactId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdContactTypeId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdField1)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdField2)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdField3)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[7];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdContactId) {
				return ssContactId;
			} else if (key == IdContactTypeId) {
				return ssContactTypeId;
			} else if (key == IdField1) {
				return ssField1;
			} else if (key == IdField2) {
				return ssField2;
			} else if (key == IdField3) {
				return ssField3;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(8);
			OptimizedAttributes = new BitArray(8);
			if (other == null) return;
			ssContactId = (long) other.AttributeGet(IdContactId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdContactId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdContactId);
			ssContactTypeId = (int) other.AttributeGet(IdContactTypeId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdContactTypeId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdContactTypeId);
			ssField1 = (string) other.AttributeGet(IdField1);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdField1);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdField1);
			ssField2 = (string) other.AttributeGet(IdField2);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdField2);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdField2);
			ssField3 = (string) other.AttributeGet(IdField3);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdField3);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdField3);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCountryId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_CTContactEntityRecord defaultStruct = new ENt_CTContactEntityRecord(null);
			if (this.ssContactId != defaultStruct.ssContactId) return false;
			if (this.ssContactTypeId != defaultStruct.ssContactTypeId) return false;
			if (this.ssField1 != defaultStruct.ssField1) return false;
			if (this.ssField2 != defaultStruct.ssField2) return false;
			if (this.ssField3 != defaultStruct.ssField3) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_CTContactEntityRecord

	public sealed partial class ENt_MGPromoterContactEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MGPromoterContact]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "promoterid", "PromoterId"
				}
				, { "contactid", "ContactId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MGPromoterContactEntity

	/// <summary>
	/// Entity <code>ENt_MGPromoterContactEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MGPromoterContact</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MGPromoterContact", "zjyUJPaE8kq2GiYpU2cu2Q", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MGPromoterContact]", null)]
	[Serializable()]
	public partial struct ENt_MGPromoterContactEntityRecord: ISerializable, ITypedRecord<ENt_MGPromoterContactEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdPromoterId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*2aynqryif0qtNs+SAOM2TQ");
		private static readonly GlobalObjectKey IdContactId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*EZqIfK_IDUmA4pNv2JWgHw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*oTwcl0AZuE+aGaMhnnkfgw");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Tnb2pU+8MUmHN8mBaL7Kxw");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("PromoterId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("PromoterId")]
		private int _ssPromoterId;
		public int ssPromoterId {
			get {
				return _ssPromoterId;
			}
			set {
				if ((_ssPromoterId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssPromoterId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ContactId")]
		private long _ssContactId;
		public long ssContactId {
			get {
				return _ssContactId;
			}
			set {
				if ((_ssContactId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssContactId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MGPromoterContactEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssPromoterId = 0;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssPromoterId = r.ReadEntityReference(index++, "t_MGPromoterContact.PromoterId", 0);
			ssContactId = r.ReadEntityReferenceLongInteger(index++, "t_MGPromoterContact.ContactId", 0L);
			ssInsertDate = r.ReadDateTime(index++, "t_MGPromoterContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MGPromoterContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MGPromoterContactEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MGPromoterContactEntityRecord a, ENt_MGPromoterContactEntityRecord b) {
			if (a.ssPromoterId != b.ssPromoterId) return false;
			if (a.ssContactId != b.ssContactId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MGPromoterContactEntityRecord a, ENt_MGPromoterContactEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MGPromoterContactEntityRecord)) return false;
			return (this == (ENt_MGPromoterContactEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssPromoterId.GetHashCode()
				^ ssContactId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MGPromoterContactEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssPromoterId = 0;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssPromoterId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssPromoterId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssPromoterId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssContactId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MGPromoterContactEntityRecord Duplicate() {
			ENt_MGPromoterContactEntityRecord t;
			t._ssPromoterId = this._ssPromoterId;
			t._ssContactId = this._ssContactId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".PromoterId")) VarValue.AppendAttribute(recordElem, "PromoterId", ssPromoterId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "PromoterId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.AppendAttribute(recordElem, "ContactId", ssContactId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ContactId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "promoterid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".PromoterId")) variable.Value = ssPromoterId; else variable.Optimized = true;
			} else if (head == "contactid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactId")) variable.Value = ssContactId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdPromoterId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdPromoterId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdPromoterId) {
				return ssPromoterId;
			} else if (key == IdContactId) {
				return ssContactId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssPromoterId = (int) other.AttributeGet(IdPromoterId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdPromoterId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdPromoterId);
			ssContactId = (long) other.AttributeGet(IdContactId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdContactId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdContactId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MGPromoterContactEntityRecord defaultStruct = new ENt_MGPromoterContactEntityRecord(null);
			if (this.ssPromoterId != defaultStruct.ssPromoterId) return false;
			if (this.ssContactId != defaultStruct.ssContactId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MGPromoterContactEntityRecord

	public sealed partial class ENt_MGFestivalContactEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MGFestivalContact]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "festivalid", "FestivalId"
				}
				, { "contactid", "ContactId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MGFestivalContactEntity

	/// <summary>
	/// Entity <code>ENt_MGFestivalContactEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MGFestivalContact</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MGFestivalContact", "+c+Q46dHdU24TX98+N+KlQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MGFestivalContact]", null)]
	[Serializable()]
	public partial struct ENt_MGFestivalContactEntityRecord: ISerializable, ITypedRecord<ENt_MGFestivalContactEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdFestivalId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*MztDClL0nECfiNrH4itT1A");
		private static readonly GlobalObjectKey IdContactId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*vdgmEiAEgUGX956VuvNvHg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*1UojmkLbmkWvwAmShKhLtA");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*sw0w+4Z7Ckm4E7cbxVy2BA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FestivalId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("FestivalId")]
		private int _ssFestivalId;
		public int ssFestivalId {
			get {
				return _ssFestivalId;
			}
			set {
				if ((_ssFestivalId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssFestivalId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ContactId")]
		private long _ssContactId;
		public long ssContactId {
			get {
				return _ssContactId;
			}
			set {
				if ((_ssContactId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssContactId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MGFestivalContactEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssFestivalId = 0;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssFestivalId = r.ReadEntityReference(index++, "t_MGFestivalContact.FestivalId", 0);
			ssContactId = r.ReadEntityReferenceLongInteger(index++, "t_MGFestivalContact.ContactId", 0L);
			ssInsertDate = r.ReadDateTime(index++, "t_MGFestivalContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MGFestivalContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MGFestivalContactEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MGFestivalContactEntityRecord a, ENt_MGFestivalContactEntityRecord b) {
			if (a.ssFestivalId != b.ssFestivalId) return false;
			if (a.ssContactId != b.ssContactId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MGFestivalContactEntityRecord a, ENt_MGFestivalContactEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MGFestivalContactEntityRecord)) return false;
			return (this == (ENt_MGFestivalContactEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssFestivalId.GetHashCode()
				^ ssContactId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MGFestivalContactEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssFestivalId = 0;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssFestivalId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFestivalId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFestivalId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssContactId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MGFestivalContactEntityRecord Duplicate() {
			ENt_MGFestivalContactEntityRecord t;
			t._ssFestivalId = this._ssFestivalId;
			t._ssContactId = this._ssContactId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FestivalId")) VarValue.AppendAttribute(recordElem, "FestivalId", ssFestivalId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "FestivalId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.AppendAttribute(recordElem, "ContactId", ssContactId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ContactId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "festivalid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FestivalId")) variable.Value = ssFestivalId; else variable.Optimized = true;
			} else if (head == "contactid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactId")) variable.Value = ssContactId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdFestivalId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdFestivalId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFestivalId) {
				return ssFestivalId;
			} else if (key == IdContactId) {
				return ssContactId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssFestivalId = (int) other.AttributeGet(IdFestivalId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdFestivalId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdFestivalId);
			ssContactId = (long) other.AttributeGet(IdContactId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdContactId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdContactId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MGFestivalContactEntityRecord defaultStruct = new ENt_MGFestivalContactEntityRecord(null);
			if (this.ssFestivalId != defaultStruct.ssFestivalId) return false;
			if (this.ssContactId != defaultStruct.ssContactId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MGFestivalContactEntityRecord

	public sealed partial class ENt_MGFestivalEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MGFestival]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "festivalid", "FestivalId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "countryid", "CountryId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MGFestivalEntity

	/// <summary>
	/// Entity <code>ENt_MGFestivalEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MGFestival</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MGFestival", "doClH8xCj0eakWSYr7tCXw", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MGFestival]", null)]
	[Serializable()]
	public partial struct ENt_MGFestivalEntityRecord: ISerializable, ITypedRecord<ENt_MGFestivalEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdFestivalId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*e0Nb2ANxbkeazI_xOMojPw");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ZkZoYbCNt0mAXYVrXUsz9w");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*4uuBvwTVqUCcGUo9JfLG8Q");
		private static readonly GlobalObjectKey IdCountryId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*lDc2TJGkaE+wb4XSdqvjsQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*wLaL9zOdGE+bKQaJ3uu+aQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*1HEF5iSyzkCVG_49SsB30w");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FestivalId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("FestivalId")]
		private int _ssFestivalId;
		public int ssFestivalId {
			get {
				return _ssFestivalId;
			}
			set {
				if ((_ssFestivalId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(6, true);
					_ssFestivalId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 150, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("CountryId", 0, false, false, true, false)]
		[System.Xml.Serialization.XmlElement("CountryId")]
		private int _ssCountryId;
		public int ssCountryId {
			get {
				return _ssCountryId;
			}
			set {
				if ((_ssCountryId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssCountryId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MGFestivalEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssFestivalId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssFestivalId = r.ReadInteger(index++, "t_MGFestival.FestivalId", 0);
			ssName = r.ReadText(index++, "t_MGFestival.Name", "");
			ssDescription = r.ReadText(index++, "t_MGFestival.Description", "");
			ssCountryId = r.ReadEntityReference(index++, "t_MGFestival.CountryId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MGFestival.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MGFestival.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(6, false);
			OptimizedAttributes = new BitArray(6, false);
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
		public void ReadIM(ENt_MGFestivalEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MGFestivalEntityRecord a, ENt_MGFestivalEntityRecord b) {
			if (a.ssFestivalId != b.ssFestivalId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssCountryId != b.ssCountryId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MGFestivalEntityRecord a, ENt_MGFestivalEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MGFestivalEntityRecord)) return false;
			return (this == (ENt_MGFestivalEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssFestivalId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssCountryId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MGFestivalEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssFestivalId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssCountryId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssFestivalId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFestivalId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFestivalId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssCountryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssCountryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssCountryId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MGFestivalEntityRecord Duplicate() {
			ENt_MGFestivalEntityRecord t;
			t._ssFestivalId = this._ssFestivalId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssCountryId = this._ssCountryId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(6);
			t.OptimizedAttributes = new BitArray(6);
			for (int i = 0; i < 6; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FestivalId")) VarValue.AppendAttribute(recordElem, "FestivalId", ssFestivalId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "FestivalId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.AppendAttribute(recordElem, "CountryId", ssCountryId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "CountryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "festivalid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FestivalId")) variable.Value = ssFestivalId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "countryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CountryId")) variable.Value = ssCountryId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdFestivalId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdFestivalId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdCountryId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdFestivalId) {
				return ssFestivalId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdCountryId) {
				return ssCountryId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(6);
			OptimizedAttributes = new BitArray(6);
			if (other == null) return;
			ssFestivalId = (int) other.AttributeGet(IdFestivalId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdFestivalId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdFestivalId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssCountryId = (int) other.AttributeGet(IdCountryId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdCountryId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCountryId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MGFestivalEntityRecord defaultStruct = new ENt_MGFestivalEntityRecord(null);
			if (this.ssFestivalId != defaultStruct.ssFestivalId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssCountryId != defaultStruct.ssCountryId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MGFestivalEntityRecord

	public sealed partial class ENt_VNVenueContactEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_VNVenueContact]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "venueid", "VenueId"
				}
				, { "contactid", "ContactId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_VNVenueContactEntity

	/// <summary>
	/// Entity <code>ENt_VNVenueContactEntityRecord</code> that represents the Service Studio entity
	///  <code>t_VNVenueContact</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_VNVenueContact", "Q5OgAXXhYUauXRik0EIr0w", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_VNVenueContact]", null)]
	[Serializable()]
	public partial struct ENt_VNVenueContactEntityRecord: ISerializable, ITypedRecord<ENt_VNVenueContactEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdVenueId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*Nual1PNE6Ue6cL17Nr8QtA");
		private static readonly GlobalObjectKey IdContactId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*3tKpek3qVEuHrlPvJNf_zQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*VRWtp99BgkilQksbrpRqZg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*L17LJN5Vw0aLYWLU81Jyig");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("VenueId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("VenueId")]
		private long _ssVenueId;
		public long ssVenueId {
			get {
				return _ssVenueId;
			}
			set {
				if ((_ssVenueId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssVenueId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ContactId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ContactId")]
		private long _ssContactId;
		public long ssContactId {
			get {
				return _ssContactId;
			}
			set {
				if ((_ssContactId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssContactId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_VNVenueContactEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssVenueId = 0L;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssVenueId = r.ReadEntityReferenceLongInteger(index++, "t_VNVenueContact.VenueId", 0L);
			ssContactId = r.ReadEntityReferenceLongInteger(index++, "t_VNVenueContact.ContactId", 0L);
			ssInsertDate = r.ReadDateTime(index++, "t_VNVenueContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_VNVenueContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_VNVenueContactEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_VNVenueContactEntityRecord a, ENt_VNVenueContactEntityRecord b) {
			if (a.ssVenueId != b.ssVenueId) return false;
			if (a.ssContactId != b.ssContactId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_VNVenueContactEntityRecord a, ENt_VNVenueContactEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_VNVenueContactEntityRecord)) return false;
			return (this == (ENt_VNVenueContactEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssVenueId.GetHashCode()
				^ ssContactId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_VNVenueContactEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssVenueId = 0L;
			_ssContactId = 0L;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssVenueId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVenueId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVenueId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssContactId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssContactId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssContactId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_VNVenueContactEntityRecord Duplicate() {
			ENt_VNVenueContactEntityRecord t;
			t._ssVenueId = this._ssVenueId;
			t._ssContactId = this._ssContactId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.AppendAttribute(recordElem, "VenueId", ssVenueId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "VenueId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.AppendAttribute(recordElem, "ContactId", ssContactId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ContactId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "venueid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".VenueId")) variable.Value = ssVenueId; else variable.Optimized = true;
			} else if (head == "contactid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ContactId")) variable.Value = ssContactId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdVenueId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdVenueId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdContactId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdVenueId) {
				return ssVenueId;
			} else if (key == IdContactId) {
				return ssContactId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssVenueId = (long) other.AttributeGet(IdVenueId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdVenueId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdVenueId);
			ssContactId = (long) other.AttributeGet(IdContactId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdContactId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdContactId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_VNVenueContactEntityRecord defaultStruct = new ENt_VNVenueContactEntityRecord(null);
			if (this.ssVenueId != defaultStruct.ssVenueId) return false;
			if (this.ssContactId != defaultStruct.ssContactId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_VNVenueContactEntityRecord

	public sealed partial class ENt_MUArtistDataSetEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistDataSet]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid", "ArtistId"
				}
				, { "datasetid", "DataSetId"
				}
				, { "version", "Version"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistDataSetEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistDataSetEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistDataSet</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistDataSet", "nMp0DWx6x0SBnen0D4gp6A", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistDataSet]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistDataSetEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistDataSetEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*haZEJ4keFEuJ02r16ShfqA");
		private static readonly GlobalObjectKey IdDataSetId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*n2uEU9XEQ0Oh9AjXgfXt9Q");
		private static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0g7OlDbBA02bGZgnzTulrg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fTgBvia7IkOZCd+gkGFHvA");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*40+LunlNG0mk0odMVEtK8A");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataSetId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("DataSetId")]
		private long _ssDataSetId;
		public long ssDataSetId {
			get {
				return _ssDataSetId;
			}
			set {
				if ((_ssDataSetId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssDataSetId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Version", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("Version")]
		private int _ssVersion;
		public int ssVersion {
			get {
				return _ssVersion;
			}
			set {
				if ((_ssVersion!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssVersion = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistDataSetEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistDataSet.ArtistId", 0);
			ssDataSetId = r.ReadEntityReferenceLongInteger(index++, "t_MUArtistDataSet.DataSetId", 0L);
			ssVersion = r.ReadEntityReference(index++, "t_MUArtistDataSet.Version", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistDataSet.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUArtistDataSet.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MUArtistDataSetEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistDataSetEntityRecord a, ENt_MUArtistDataSetEntityRecord b) {
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssDataSetId != b.ssDataSetId) return false;
			if (a.ssVersion != b.ssVersion) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistDataSetEntityRecord a, ENt_MUArtistDataSetEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistDataSetEntityRecord)) return false;
			return (this == (ENt_MUArtistDataSetEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssDataSetId.GetHashCode()
				^ ssVersion.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistDataSetEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssArtistId = 0;
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDataSetId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataSetId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataSetId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVersion = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistDataSetEntityRecord Duplicate() {
			ENt_MUArtistDataSetEntityRecord t;
			t._ssArtistId = this._ssArtistId;
			t._ssDataSetId = this._ssDataSetId;
			t._ssVersion = this._ssVersion;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataSetId")) VarValue.AppendAttribute(recordElem, "DataSetId", ssDataSetId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataSetId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Version")) VarValue.AppendAttribute(recordElem, "Version", ssVersion, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "Version");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "datasetid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataSetId")) variable.Value = ssDataSetId; else variable.Optimized = true;
			} else if (head == "version") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdDataSetId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdVersion)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdDataSetId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdVersion)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdDataSetId) {
				return ssDataSetId;
			} else if (key == IdVersion) {
				return ssVersion;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId);
			ssDataSetId = (long) other.AttributeGet(IdDataSetId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdDataSetId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDataSetId);
			ssVersion = (int) other.AttributeGet(IdVersion);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdVersion);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdVersion);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistDataSetEntityRecord defaultStruct = new ENt_MUArtistDataSetEntityRecord(null);
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssDataSetId != defaultStruct.ssDataSetId) return false;
			if (this.ssVersion != defaultStruct.ssVersion) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistDataSetEntityRecord

	public sealed partial class ENt_STDataSetEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_STDataSet]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "datasetid", "DataSetId"
				}
				, { "version", "Version"
				}
				, { "datasettypeid", "DataSetTypeId"
				}
				, { "referencedate", "ReferenceDate"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_STDataSetEntity

	/// <summary>
	/// Entity <code>ENt_STDataSetEntityRecord</code> that represents the Service Studio entity
	///  <code>t_STDataSet</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_STDataSet", "xw_YU8LIFkuTQNLWLP7YVQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_STDataSet]", null)]
	[Serializable()]
	public partial struct ENt_STDataSetEntityRecord: ISerializable, ITypedRecord<ENt_STDataSetEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdDataSetId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*YMz8lQqMp0mh7NSqiA5jnQ");
		private static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fGHeLFwN3UG7g5tac0SskQ");
		private static readonly GlobalObjectKey IdDataSetTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*798CcWDI_U2g_M9tXAX6Dw");
		private static readonly GlobalObjectKey IdReferenceDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*BoXQnlr5CUm0qHvAVLJAFg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*rejv7YtfPkiVw64V1MCfuw");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*v7vDDLQf8kWMCxtHEsmaSA");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataSetId", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("DataSetId")]
		private long _ssDataSetId;
		public long ssDataSetId {
			get {
				return _ssDataSetId;
			}
			set {
				if ((_ssDataSetId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssDataSetId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Version", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Version")]
		private int _ssVersion;
		public int ssVersion {
			get {
				return _ssVersion;
			}
			set {
				if ((_ssVersion!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssVersion = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataSetTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("DataSetTypeId")]
		private int _ssDataSetTypeId;
		public int ssDataSetTypeId {
			get {
				return _ssDataSetTypeId;
			}
			set {
				if ((_ssDataSetTypeId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDataSetTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ReferenceDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("ReferenceDate")]
		private DateTime _ssReferenceDate;
		public DateTime ssReferenceDate {
			get {
				return _ssReferenceDate;
			}
			set {
				if ((_ssReferenceDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssReferenceDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_STDataSetEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssDataSetTypeId = 0;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDataSetId = r.ReadLongInteger(index++, "t_STDataSet.DataSetId", 0L);
			ssVersion = r.ReadInteger(index++, "t_STDataSet.Version", 0);
			ssDataSetTypeId = r.ReadEntityReference(index++, "t_STDataSet.DataSetTypeId", 0);
			ssReferenceDate = r.ReadDateTime(index++, "t_STDataSet.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssInsertDate = r.ReadDateTime(index++, "t_STDataSet.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_STDataSet.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(6, false);
			OptimizedAttributes = new BitArray(6, false);
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
		public void ReadIM(ENt_STDataSetEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_STDataSetEntityRecord a, ENt_STDataSetEntityRecord b) {
			if (a.ssDataSetId != b.ssDataSetId) return false;
			if (a.ssVersion != b.ssVersion) return false;
			if (a.ssDataSetTypeId != b.ssDataSetTypeId) return false;
			if (a.ssReferenceDate != b.ssReferenceDate) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_STDataSetEntityRecord a, ENt_STDataSetEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_STDataSetEntityRecord)) return false;
			return (this == (ENt_STDataSetEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDataSetId.GetHashCode()
				^ ssVersion.GetHashCode()
				^ ssDataSetTypeId.GetHashCode()
				^ ssReferenceDate.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_STDataSetEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(6, true);
			OptimizedAttributes = new BitArray(6, false);
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssDataSetTypeId = 0;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssDataSetId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataSetId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataSetId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVersion = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDataSetTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataSetTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataSetTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssReferenceDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssReferenceDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssReferenceDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_STDataSetEntityRecord Duplicate() {
			ENt_STDataSetEntityRecord t;
			t._ssDataSetId = this._ssDataSetId;
			t._ssVersion = this._ssVersion;
			t._ssDataSetTypeId = this._ssDataSetTypeId;
			t._ssReferenceDate = this._ssReferenceDate;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(6);
			t.OptimizedAttributes = new BitArray(6);
			for (int i = 0; i < 6; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataSetId")) VarValue.AppendAttribute(recordElem, "DataSetId", ssDataSetId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataSetId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Version")) VarValue.AppendAttribute(recordElem, "Version", ssVersion, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "Version");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataSetTypeId")) VarValue.AppendAttribute(recordElem, "DataSetTypeId", ssDataSetTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "DataSetTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ReferenceDate")) VarValue.AppendAttribute(recordElem, "ReferenceDate", ssReferenceDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "ReferenceDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datasetid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataSetId")) variable.Value = ssDataSetId; else variable.Optimized = true;
			} else if (head == "version") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
			} else if (head == "datasettypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataSetTypeId")) variable.Value = ssDataSetTypeId; else variable.Optimized = true;
			} else if (head == "referencedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceDate")) variable.Value = ssReferenceDate; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataSetId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdVersion)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDataSetTypeId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdReferenceDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataSetId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdVersion)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDataSetTypeId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdReferenceDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[5];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDataSetId) {
				return ssDataSetId;
			} else if (key == IdVersion) {
				return ssVersion;
			} else if (key == IdDataSetTypeId) {
				return ssDataSetTypeId;
			} else if (key == IdReferenceDate) {
				return ssReferenceDate;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(6);
			OptimizedAttributes = new BitArray(6);
			if (other == null) return;
			ssDataSetId = (long) other.AttributeGet(IdDataSetId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdDataSetId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDataSetId);
			ssVersion = (int) other.AttributeGet(IdVersion);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdVersion);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdVersion);
			ssDataSetTypeId = (int) other.AttributeGet(IdDataSetTypeId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDataSetTypeId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDataSetTypeId);
			ssReferenceDate = (DateTime) other.AttributeGet(IdReferenceDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdReferenceDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdReferenceDate);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_STDataSetEntityRecord defaultStruct = new ENt_STDataSetEntityRecord(null);
			if (this.ssDataSetId != defaultStruct.ssDataSetId) return false;
			if (this.ssVersion != defaultStruct.ssVersion) return false;
			if (this.ssDataSetTypeId != defaultStruct.ssDataSetTypeId) return false;
			if (this.ssReferenceDate != defaultStruct.ssReferenceDate) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_STDataSetEntityRecord

	public sealed partial class ENt_STDataPointEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_STDataPoint]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "datapointid", "DataPointId"
				}
				, { "datasetid", "DataSetId"
				}
				, { "version", "Version"
				}
				, { "datapointtypeid", "DataPointTypeId"
				}
				, { "label", "Label"
				}
				, { "value", "Value"
				}
				, { "referencedate", "ReferenceDate"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_STDataPointEntity

	/// <summary>
	/// Entity <code>ENt_STDataPointEntityRecord</code> that represents the Service Studio entity
	///  <code>t_STDataPoint</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_STDataPoint", "Hna7DFT2HkyjP+dKQxSlyA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_STDataPoint]", null)]
	[Serializable()]
	public partial struct ENt_STDataPointEntityRecord: ISerializable, ITypedRecord<ENt_STDataPointEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdDataPointId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*iYfCdVcbFkGptVQoM6SEBQ");
		private static readonly GlobalObjectKey IdDataSetId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*nvAqKI8T_UWBwUXcYpxOfQ");
		private static readonly GlobalObjectKey IdVersion = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*VESTXkN6ZU+GgQH3InBnjQ");
		private static readonly GlobalObjectKey IdDataPointTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0eVQBcW+RUGQzqssAlv+CA");
		private static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*vE_dXgAaEEq3V6a85kDVzQ");
		private static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*_4zbDIVFXkKBAFKiwJ6dnQ");
		private static readonly GlobalObjectKey IdReferenceDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*T0o95_OYVkikDWrjoZfXdA");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0gK42qeprESJCJtjnDKwqw");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*ZxrnjVTwIEe+I3t18MX07A");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataPointId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("DataPointId")]
		private long _ssDataPointId;
		public long ssDataPointId {
			get {
				return _ssDataPointId;
			}
			set {
				if ((_ssDataPointId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(9, true);
					_ssDataPointId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataSetId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("DataSetId")]
		private long _ssDataSetId;
		public long ssDataSetId {
			get {
				return _ssDataSetId;
			}
			set {
				if ((_ssDataSetId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssDataSetId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Version", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("Version")]
		private int _ssVersion;
		public int ssVersion {
			get {
				return _ssVersion;
			}
			set {
				if ((_ssVersion!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssVersion = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataPointTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("DataPointTypeId")]
		private int _ssDataPointTypeId;
		public int ssDataPointTypeId {
			get {
				return _ssDataPointTypeId;
			}
			set {
				if ((_ssDataPointTypeId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssDataPointTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Label", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Label")]
		private string _ssLabel;
		public string ssLabel {
			get {
				return _ssLabel;
			}
			set {
				if ((_ssLabel!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssLabel = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Value", 18, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("Value")]
		private decimal _ssValue;
		public decimal ssValue {
			get {
				return _ssValue;
			}
			set {
				if ((_ssValue!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssValue = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ReferenceDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("ReferenceDate")]
		private DateTime _ssReferenceDate;
		public DateTime ssReferenceDate {
			get {
				return _ssReferenceDate;
			}
			set {
				if ((_ssReferenceDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssReferenceDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[7]) {
					ChangedAttributes[7] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[8]) {
					ChangedAttributes[8] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_STDataPointEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(9, true);
			OptimizedAttributes = new BitArray(9, false);
			_ssDataPointId = 0L;
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssDataPointTypeId = 0;
			_ssLabel = "";
			_ssValue = 0.0M;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDataPointId = r.ReadLongInteger(index++, "t_STDataPoint.DataPointId", 0L);
			ssDataSetId = r.ReadEntityReferenceLongInteger(index++, "t_STDataPoint.DataSetId", 0L);
			ssVersion = r.ReadEntityReference(index++, "t_STDataPoint.Version", 0);
			ssDataPointTypeId = r.ReadEntityReference(index++, "t_STDataPoint.DataPointTypeId", 0);
			ssLabel = r.ReadText(index++, "t_STDataPoint.Label", "");
			ssValue = r.ReadDecimal(index++, "t_STDataPoint.Value", 0.0M);
			ssReferenceDate = r.ReadDateTime(index++, "t_STDataPoint.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssInsertDate = r.ReadDateTime(index++, "t_STDataPoint.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_STDataPoint.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(9, false);
			OptimizedAttributes = new BitArray(9, false);
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
		public void ReadIM(ENt_STDataPointEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_STDataPointEntityRecord a, ENt_STDataPointEntityRecord b) {
			if (a.ssDataPointId != b.ssDataPointId) return false;
			if (a.ssDataSetId != b.ssDataSetId) return false;
			if (a.ssVersion != b.ssVersion) return false;
			if (a.ssDataPointTypeId != b.ssDataPointTypeId) return false;
			if (a.ssLabel != b.ssLabel) return false;
			if (a.ssValue != b.ssValue) return false;
			if (a.ssReferenceDate != b.ssReferenceDate) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_STDataPointEntityRecord a, ENt_STDataPointEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_STDataPointEntityRecord)) return false;
			return (this == (ENt_STDataPointEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDataPointId.GetHashCode()
				^ ssDataSetId.GetHashCode()
				^ ssVersion.GetHashCode()
				^ ssDataPointTypeId.GetHashCode()
				^ ssLabel.GetHashCode()
				^ ssValue.GetHashCode()
				^ ssReferenceDate.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_STDataPointEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(9, true);
			OptimizedAttributes = new BitArray(9, false);
			_ssDataPointId = 0L;
			_ssDataSetId = 0L;
			_ssVersion = 0;
			_ssDataPointTypeId = 0;
			_ssLabel = "";
			_ssValue = 0.0M;
			_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssDataPointId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataPointId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataPointId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDataSetId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataSetId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataSetId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssVersion = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDataPointTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataPointTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataPointTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssLabel", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssLabel' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssLabel = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssValue = (decimal) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssReferenceDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssReferenceDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssReferenceDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_STDataPointEntityRecord Duplicate() {
			ENt_STDataPointEntityRecord t;
			t._ssDataPointId = this._ssDataPointId;
			t._ssDataSetId = this._ssDataSetId;
			t._ssVersion = this._ssVersion;
			t._ssDataPointTypeId = this._ssDataPointTypeId;
			t._ssLabel = this._ssLabel;
			t._ssValue = this._ssValue;
			t._ssReferenceDate = this._ssReferenceDate;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(9);
			t.OptimizedAttributes = new BitArray(9);
			for (int i = 0; i < 9; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataPointId")) VarValue.AppendAttribute(recordElem, "DataPointId", ssDataPointId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataPointId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataSetId")) VarValue.AppendAttribute(recordElem, "DataSetId", ssDataSetId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataSetId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Version")) VarValue.AppendAttribute(recordElem, "Version", ssVersion, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "Version");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataPointTypeId")) VarValue.AppendAttribute(recordElem, "DataPointTypeId", ssDataPointTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "DataPointTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Label")) VarValue.AppendAttribute(recordElem, "Label", ssLabel, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Label");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Value")) VarValue.AppendAttribute(recordElem, "Value", ssValue, detailLevel, TypeKind.Decimal); else VarValue.AppendOptimizedAttribute(recordElem, "Value");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ReferenceDate")) VarValue.AppendAttribute(recordElem, "ReferenceDate", ssReferenceDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "ReferenceDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datapointid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataPointId")) variable.Value = ssDataPointId; else variable.Optimized = true;
			} else if (head == "datasetid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataSetId")) variable.Value = ssDataSetId; else variable.Optimized = true;
			} else if (head == "version") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Version")) variable.Value = ssVersion; else variable.Optimized = true;
			} else if (head == "datapointtypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataPointTypeId")) variable.Value = ssDataPointTypeId; else variable.Optimized = true;
			} else if (head == "label") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
			} else if (head == "value") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
			} else if (head == "referencedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ReferenceDate")) variable.Value = ssReferenceDate; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataPointId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdDataSetId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdVersion)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdDataPointTypeId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdLabel)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdValue)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdReferenceDate)) {
				return ChangedAttributes[6];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[7];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[8];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataPointId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdDataSetId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdVersion)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdDataPointTypeId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdLabel)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdValue)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdReferenceDate)) {
				return OptimizedAttributes[6];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[7];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[8];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDataPointId) {
				return ssDataPointId;
			} else if (key == IdDataSetId) {
				return ssDataSetId;
			} else if (key == IdVersion) {
				return ssVersion;
			} else if (key == IdDataPointTypeId) {
				return ssDataPointTypeId;
			} else if (key == IdLabel) {
				return ssLabel;
			} else if (key == IdValue) {
				return ssValue;
			} else if (key == IdReferenceDate) {
				return ssReferenceDate;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(9);
			OptimizedAttributes = new BitArray(9);
			if (other == null) return;
			ssDataPointId = (long) other.AttributeGet(IdDataPointId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdDataPointId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDataPointId);
			ssDataSetId = (long) other.AttributeGet(IdDataSetId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdDataSetId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDataSetId);
			ssVersion = (int) other.AttributeGet(IdVersion);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdVersion);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdVersion);
			ssDataPointTypeId = (int) other.AttributeGet(IdDataPointTypeId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdDataPointTypeId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDataPointTypeId);
			ssLabel = (string) other.AttributeGet(IdLabel);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdLabel);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdLabel);
			ssValue = (decimal) other.AttributeGet(IdValue);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdValue);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdValue);
			ssReferenceDate = (DateTime) other.AttributeGet(IdReferenceDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdReferenceDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdReferenceDate);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[7] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[7] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[8] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[8] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_STDataPointEntityRecord defaultStruct = new ENt_STDataPointEntityRecord(null);
			if (this.ssDataPointId != defaultStruct.ssDataPointId) return false;
			if (this.ssDataSetId != defaultStruct.ssDataSetId) return false;
			if (this.ssVersion != defaultStruct.ssVersion) return false;
			if (this.ssDataPointTypeId != defaultStruct.ssDataPointTypeId) return false;
			if (this.ssLabel != defaultStruct.ssLabel) return false;
			if (this.ssValue != defaultStruct.ssValue) return false;
			if (this.ssReferenceDate != defaultStruct.ssReferenceDate) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_STDataPointEntityRecord

	public sealed partial class ENt_MDDataSetEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDDataSet]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "datasettypeid", "DataSetTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDDataSetEntity

	/// <summary>
	/// Entity <code>ENt_MDDataSetEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDDataSet</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDDataSet", "WAiklcHERUCENYt1YtU8uw", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDDataSet]", null)]
	[Serializable()]
	public partial struct ENt_MDDataSetEntityRecord: ISerializable, ITypedRecord<ENt_MDDataSetEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdDataSetTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*DR+NEk2AZUyykb6qxP7kvw");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*6dOImG6FG0+jXuXvbFaf7Q");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*yywZ5zFvV0eT8o_ocvEkYw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*NdjVzkujokSjkFkw8SAqUg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*4LvAwrYsD0CcUsZSLIci+Q");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("DataSetTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("DataSetTypeId")]
		private int _ssDataSetTypeId;
		public int ssDataSetTypeId {
			get {
				return _ssDataSetTypeId;
			}
			set {
				if ((_ssDataSetTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssDataSetTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDDataSetEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssDataSetTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDataSetTypeId = r.ReadInteger(index++, "t_MDDataSet.DataSetTypeId", 0);
			ssName = r.ReadText(index++, "t_MDDataSet.Name", "");
			ssDescription = r.ReadText(index++, "t_MDDataSet.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDDataSet.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDDataSet.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDDataSetEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDDataSetEntityRecord a, ENt_MDDataSetEntityRecord b) {
			if (a.ssDataSetTypeId != b.ssDataSetTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDDataSetEntityRecord a, ENt_MDDataSetEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDDataSetEntityRecord)) return false;
			return (this == (ENt_MDDataSetEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDataSetTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDDataSetEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssDataSetTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssDataSetTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDataSetTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDataSetTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDDataSetEntityRecord Duplicate() {
			ENt_MDDataSetEntityRecord t;
			t._ssDataSetTypeId = this._ssDataSetTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataSetTypeId")) VarValue.AppendAttribute(recordElem, "DataSetTypeId", ssDataSetTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "DataSetTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datasettypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataSetTypeId")) variable.Value = ssDataSetTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataSetTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdDataSetTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdDataSetTypeId) {
				return ssDataSetTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssDataSetTypeId = (int) other.AttributeGet(IdDataSetTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdDataSetTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdDataSetTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDDataSetEntityRecord defaultStruct = new ENt_MDDataSetEntityRecord(null);
			if (this.ssDataSetTypeId != defaultStruct.ssDataSetTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDDataSetEntityRecord

	public sealed partial class ENt_MUArtistAlbumEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistAlbum]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "artistid", "ArtistId"
				}
				, { "albumid", "AlbumId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistAlbumEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistAlbumEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistAlbum</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistAlbum", "Qvr7nRrhx0OhCbxMjpQQRw", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistAlbum]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistAlbumEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistAlbumEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*FMFjRJtJxkauJ6mBO73YNw");
		private static readonly GlobalObjectKey IdAlbumId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*kVoJtgTSr0meLS4ciHwzmw");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*egCA9GemXkejm_jbtEAX_g");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*D08HoTwZlkueVcJHHhGAQg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AlbumId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("AlbumId")]
		private int _ssAlbumId;
		public int ssAlbumId {
			get {
				return _ssAlbumId;
			}
			set {
				if ((_ssAlbumId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssAlbumId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistAlbumEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssArtistId = 0;
			_ssAlbumId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistAlbum.ArtistId", 0);
			ssAlbumId = r.ReadEntityReference(index++, "t_MUArtistAlbum.AlbumId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistAlbum.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDate(index++, "t_MUArtistAlbum.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MUArtistAlbumEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistAlbumEntityRecord a, ENt_MUArtistAlbumEntityRecord b) {
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssAlbumId != b.ssAlbumId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistAlbumEntityRecord a, ENt_MUArtistAlbumEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistAlbumEntityRecord)) return false;
			return (this == (ENt_MUArtistAlbumEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssAlbumId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistAlbumEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssArtistId = 0;
			_ssAlbumId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAlbumId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAlbumId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAlbumId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistAlbumEntityRecord Duplicate() {
			ENt_MUArtistAlbumEntityRecord t;
			t._ssArtistId = this._ssArtistId;
			t._ssAlbumId = this._ssAlbumId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AlbumId")) VarValue.AppendAttribute(recordElem, "AlbumId", ssAlbumId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "AlbumId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.Date); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "albumid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AlbumId")) variable.Value = ssAlbumId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdAlbumId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdAlbumId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdAlbumId) {
				return ssAlbumId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdArtistId);
			ssAlbumId = (int) other.AttributeGet(IdAlbumId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdAlbumId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdAlbumId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistAlbumEntityRecord defaultStruct = new ENt_MUArtistAlbumEntityRecord(null);
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssAlbumId != defaultStruct.ssAlbumId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistAlbumEntityRecord

	public sealed partial class ENt_MDMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "mediatypeid", "MediaTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDMediaEntity

	/// <summary>
	/// Entity <code>ENt_MDMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDMedia", "nZRqQtf0A0uILEqoSmuzww", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDMedia]", null)]
	[Serializable()]
	public partial struct ENt_MDMediaEntityRecord: ISerializable, ITypedRecord<ENt_MDMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMediaTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*_ec16wVN1ES4RSBlKy3N9w");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*IIU+SMgRT0SJkm9abiOW3Q");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*L1e6h+Ez3kWL1qP12KoqPA");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*C1paOf8ZUE26XlFSy5Xm3g");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*0B32KOSVx0GMhCUZhvaOjg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("MediaTypeId")]
		private int _ssMediaTypeId;
		public int ssMediaTypeId {
			get {
				return _ssMediaTypeId;
			}
			set {
				if ((_ssMediaTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssMediaTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMediaTypeId = r.ReadInteger(index++, "t_MDMedia.MediaTypeId", 0);
			ssName = r.ReadText(index++, "t_MDMedia.Name", "");
			ssDescription = r.ReadText(index++, "t_MDMedia.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDMediaEntityRecord a, ENt_MDMediaEntityRecord b) {
			if (a.ssMediaTypeId != b.ssMediaTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDMediaEntityRecord a, ENt_MDMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDMediaEntityRecord)) return false;
			return (this == (ENt_MDMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMediaTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMediaTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDMediaEntityRecord Duplicate() {
			ENt_MDMediaEntityRecord t;
			t._ssMediaTypeId = this._ssMediaTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaTypeId")) VarValue.AppendAttribute(recordElem, "MediaTypeId", ssMediaTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "MediaTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mediatypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaTypeId")) variable.Value = ssMediaTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMediaTypeId) {
				return ssMediaTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssMediaTypeId = (int) other.AttributeGet(IdMediaTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMediaTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMediaTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDMediaEntityRecord defaultStruct = new ENt_MDMediaEntityRecord(null);
			if (this.ssMediaTypeId != defaultStruct.ssMediaTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDMediaEntityRecord

	public sealed partial class ENt_MTMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MTMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "mediaid", "MediaId"
				}
				, { "filename", "FileName"
				}
				, { "mimetype", "MimeType"
				}
				, { "mediafiletypeid", "MediaFileTypeId"
				}
				, { "filebinary", "FileBinary"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MTMediaEntity

	/// <summary>
	/// Entity <code>ENt_MTMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MTMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MTMedia", "xeRLXMchgkKq8Mk2IK7NIw", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MTMedia]", null)]
	[Serializable()]
	public partial struct ENt_MTMediaEntityRecord: ISerializable, ITypedRecord<ENt_MTMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*5oMmsJehkk+J7e226SqQYw");
		private static readonly GlobalObjectKey IdFileName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*NuLPX6fZr0iDSL_6OyR3jg");
		private static readonly GlobalObjectKey IdMimeType = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*bsr7ytnU1UWK4x8DpSsiFw");
		private static readonly GlobalObjectKey IdMediaFileTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*QV9WrjD3T0yqgNmThF0Qrw");
		private static readonly GlobalObjectKey IdFileBinary = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*JN0WNxEfLUOleMhQHBiTLg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*EmDcdW5RYkejX5l5Qs4VHg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fZgQIoZ13UieE8gJle8uWQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("MediaId")]
		private long _ssMediaId;
		public long ssMediaId {
			get {
				return _ssMediaId;
			}
			set {
				if ((_ssMediaId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(7, true);
					_ssMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FileName", 255, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("FileName")]
		private string _ssFileName;
		public string ssFileName {
			get {
				return _ssFileName;
			}
			set {
				if ((_ssFileName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssFileName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MimeType", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("MimeType")]
		private string _ssMimeType;
		public string ssMimeType {
			get {
				return _ssMimeType;
			}
			set {
				if ((_ssMimeType!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssMimeType = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaFileTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MediaFileTypeId")]
		private int _ssMediaFileTypeId;
		public int ssMediaFileTypeId {
			get {
				return _ssMediaFileTypeId;
			}
			set {
				if ((_ssMediaFileTypeId!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssMediaFileTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("FileBinary", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("FileBinary")]
		private byte[] _ssFileBinary;
		public byte[] ssFileBinary {
			get {
				return _ssFileBinary;
			}
			set {
				if ((_ssFileBinary!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssFileBinary = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[5]) {
					ChangedAttributes[5] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[6]) {
					ChangedAttributes[6] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MTMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssMediaId = 0L;
			_ssFileName = "";
			_ssMimeType = "";
			_ssMediaFileTypeId = 0;
			_ssFileBinary = new byte[] {};
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMediaId = r.ReadLongInteger(index++, "t_MTMedia.MediaId", 0L);
			ssFileName = r.ReadText(index++, "t_MTMedia.FileName", "");
			ssMimeType = r.ReadText(index++, "t_MTMedia.MimeType", "");
			ssMediaFileTypeId = r.ReadEntityReference(index++, "t_MTMedia.MediaFileTypeId", 0);
			ssFileBinary = r.ReadBinaryData(index++, "t_MTMedia.FileBinary", new byte[] {});
			ssInsertDate = r.ReadDateTime(index++, "t_MTMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MTMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(7, false);
			OptimizedAttributes = new BitArray(7, false);
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
		public void ReadIM(ENt_MTMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MTMediaEntityRecord a, ENt_MTMediaEntityRecord b) {
			if (a.ssMediaId != b.ssMediaId) return false;
			if (a.ssFileName != b.ssFileName) return false;
			if (a.ssMimeType != b.ssMimeType) return false;
			if (a.ssMediaFileTypeId != b.ssMediaFileTypeId) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(a.ssFileBinary, b.ssFileBinary)) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MTMediaEntityRecord a, ENt_MTMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MTMediaEntityRecord)) return false;
			return (this == (ENt_MTMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMediaId.GetHashCode()
				^ ssFileName.GetHashCode()
				^ ssMimeType.GetHashCode()
				^ ssMediaFileTypeId.GetHashCode()
				^ ssFileBinary.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MTMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(7, true);
			OptimizedAttributes = new BitArray(7, false);
			_ssMediaId = 0L;
			_ssFileName = "";
			_ssMimeType = "";
			_ssMediaFileTypeId = 0;
			_ssFileBinary = new byte[] {};
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFileName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFileName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFileName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssMimeType", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMimeType' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMimeType = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssMediaFileTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaFileTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaFileTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssFileBinary", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssFileBinary' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssFileBinary = (byte[]) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MTMediaEntityRecord Duplicate() {
			ENt_MTMediaEntityRecord t;
			t._ssMediaId = this._ssMediaId;
			t._ssFileName = this._ssFileName;
			t._ssMimeType = this._ssMimeType;
			t._ssMediaFileTypeId = this._ssMediaFileTypeId;
			if (this._ssFileBinary != null) {
				t._ssFileBinary = (byte[]) this._ssFileBinary.Clone();
			} else {
				t._ssFileBinary = null;
			}
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(7);
			t.OptimizedAttributes = new BitArray(7);
			for (int i = 0; i < 7; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaId")) VarValue.AppendAttribute(recordElem, "MediaId", ssMediaId, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "MediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FileName")) VarValue.AppendAttribute(recordElem, "FileName", ssFileName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "FileName");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MimeType")) VarValue.AppendAttribute(recordElem, "MimeType", ssMimeType, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "MimeType");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaFileTypeId")) VarValue.AppendAttribute(recordElem, "MediaFileTypeId", ssMediaFileTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "MediaFileTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".FileBinary")) VarValue.AppendAttribute(recordElem, "FileBinary", ssFileBinary, detailLevel, TypeKind.BinaryData); else VarValue.AppendOptimizedAttribute(recordElem, "FileBinary");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaId")) variable.Value = ssMediaId; else variable.Optimized = true;
			} else if (head == "filename") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FileName")) variable.Value = ssFileName; else variable.Optimized = true;
			} else if (head == "mimetype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MimeType")) variable.Value = ssMimeType; else variable.Optimized = true;
			} else if (head == "mediafiletypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaFileTypeId")) variable.Value = ssMediaFileTypeId; else variable.Optimized = true;
			} else if (head == "filebinary") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".FileBinary")) variable.Value = ssFileBinary; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdFileName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdMimeType)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdMediaFileTypeId)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdFileBinary)) {
				return ChangedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdFileName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdMimeType)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdMediaFileTypeId)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdFileBinary)) {
				return OptimizedAttributes[4];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[5];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[6];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMediaId) {
				return ssMediaId;
			} else if (key == IdFileName) {
				return ssFileName;
			} else if (key == IdMimeType) {
				return ssMimeType;
			} else if (key == IdMediaFileTypeId) {
				return ssMediaFileTypeId;
			} else if (key == IdFileBinary) {
				return ssFileBinary;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(7);
			OptimizedAttributes = new BitArray(7);
			if (other == null) return;
			ssMediaId = (long) other.AttributeGet(IdMediaId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMediaId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMediaId);
			ssFileName = (string) other.AttributeGet(IdFileName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdFileName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdFileName);
			ssMimeType = (string) other.AttributeGet(IdMimeType);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdMimeType);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMimeType);
			ssMediaFileTypeId = (int) other.AttributeGet(IdMediaFileTypeId);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdMediaFileTypeId);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMediaFileTypeId);
			ssFileBinary = (byte[]) other.AttributeGet(IdFileBinary);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdFileBinary);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdFileBinary);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[5] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[5] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MTMediaEntityRecord defaultStruct = new ENt_MTMediaEntityRecord(null);
			if (this.ssMediaId != defaultStruct.ssMediaId) return false;
			if (this.ssFileName != defaultStruct.ssFileName) return false;
			if (this.ssMimeType != defaultStruct.ssMimeType) return false;
			if (this.ssMediaFileTypeId != defaultStruct.ssMediaFileTypeId) return false;
			if (!RuntimePlatformUtils.CompareByteArrays(this.ssFileBinary, defaultStruct.ssFileBinary)) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MTMediaEntityRecord

	public sealed partial class ENt_MUArtistMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "mediaid", "MediaId"
				}
				, { "artistid", "ArtistId"
				}
				, { "mediatypeid", "MediaTypeId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistMediaEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistMedia", "agOURwTH8UqHy1KEq4FQeQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistMedia]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistMediaEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*moZjltueV0qfObfI4DJAKA");
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*C3BLXsZ1n0uQZLWNP0T29Q");
		private static readonly GlobalObjectKey IdMediaTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*oN7OEpgF8EyiRFkjJaKKLQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*QVMR4fkZXUOOXQsjY8grhQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*TQcBjHmRTE+z+ugAuE96Tg");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MediaId")]
		private long _ssMediaId;
		public long ssMediaId {
			get {
				return _ssMediaId;
			}
			set {
				if ((_ssMediaId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MediaTypeId")]
		private int _ssMediaTypeId;
		public int ssMediaTypeId {
			get {
				return _ssMediaTypeId;
			}
			set {
				if ((_ssMediaTypeId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssMediaTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaId = 0L;
			_ssArtistId = 0;
			_ssMediaTypeId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMediaId = r.ReadEntityReferenceLongInteger(index++, "t_MUArtistMedia.MediaId", 0L);
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistMedia.ArtistId", 0);
			ssMediaTypeId = r.ReadEntityReference(index++, "t_MUArtistMedia.MediaTypeId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUArtistMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MUArtistMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistMediaEntityRecord a, ENt_MUArtistMediaEntityRecord b) {
			if (a.ssMediaId != b.ssMediaId) return false;
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssMediaTypeId != b.ssMediaTypeId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistMediaEntityRecord a, ENt_MUArtistMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistMediaEntityRecord)) return false;
			return (this == (ENt_MUArtistMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMediaId.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssMediaTypeId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaId = 0L;
			_ssArtistId = 0;
			_ssMediaTypeId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssMediaTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistMediaEntityRecord Duplicate() {
			ENt_MUArtistMediaEntityRecord t;
			t._ssMediaId = this._ssMediaId;
			t._ssArtistId = this._ssArtistId;
			t._ssMediaTypeId = this._ssMediaTypeId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaId")) VarValue.AppendAttribute(recordElem, "MediaId", ssMediaId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "MediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaTypeId")) VarValue.AppendAttribute(recordElem, "MediaTypeId", ssMediaTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "MediaTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaId")) variable.Value = ssMediaId; else variable.Optimized = true;
			} else if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "mediatypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaTypeId")) variable.Value = ssMediaTypeId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdMediaTypeId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdMediaTypeId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMediaId) {
				return ssMediaId;
			} else if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdMediaTypeId) {
				return ssMediaTypeId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssMediaId = (long) other.AttributeGet(IdMediaId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMediaId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMediaId);
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdArtistId);
			ssMediaTypeId = (int) other.AttributeGet(IdMediaTypeId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdMediaTypeId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMediaTypeId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistMediaEntityRecord defaultStruct = new ENt_MUArtistMediaEntityRecord(null);
			if (this.ssMediaId != defaultStruct.ssMediaId) return false;
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssMediaTypeId != defaultStruct.ssMediaTypeId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistMediaEntityRecord

	public sealed partial class ENt_MDMediaFileEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MDMediaFile]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "mediafiletypeid", "MediaFileTypeId"
				}
				, { "name", "Name"
				}
				, { "description", "Description"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MDMediaFileEntity

	/// <summary>
	/// Entity <code>ENt_MDMediaFileEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MDMediaFile</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MDMediaFile", "2zxojAjhPE2TIVA_zoeltA", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MDMediaFile]", null)]
	[Serializable()]
	public partial struct ENt_MDMediaFileEntityRecord: ISerializable, ITypedRecord<ENt_MDMediaFileEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMediaFileTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*FdyTrnnc8EW2RTgZA+hHJQ");
		private static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*pWnIDnCrYkae4ubptvOaQg");
		private static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*zrUgbSzvt0O_KX2k_3smjQ");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*drmIU_Kqf0KfdRbMn53pBQ");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*n6R16P6uC0y8f8m9FtE6tQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaFileTypeId", 0, true, true, false, true)]
		[System.Xml.Serialization.XmlElement("MediaFileTypeId")]
		private int _ssMediaFileTypeId;
		public int ssMediaFileTypeId {
			get {
				return _ssMediaFileTypeId;
			}
			set {
				if ((_ssMediaFileTypeId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes = new BitArray(5, true);
					_ssMediaFileTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Name", 50, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Name")]
		private string _ssName;
		public string ssName {
			get {
				return _ssName;
			}
			set {
				if ((_ssName!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssName = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("Description", 500, false, false, false, false)]
		[System.Xml.Serialization.XmlElement("Description")]
		private string _ssDescription;
		public string ssDescription {
			get {
				return _ssDescription;
			}
			set {
				if ((_ssDescription!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssDescription = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MDMediaFileEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaFileTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMediaFileTypeId = r.ReadInteger(index++, "t_MDMediaFile.MediaFileTypeId", 0);
			ssName = r.ReadText(index++, "t_MDMediaFile.Name", "");
			ssDescription = r.ReadText(index++, "t_MDMediaFile.Description", "");
			ssInsertDate = r.ReadDateTime(index++, "t_MDMediaFile.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MDMediaFile.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MDMediaFileEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MDMediaFileEntityRecord a, ENt_MDMediaFileEntityRecord b) {
			if (a.ssMediaFileTypeId != b.ssMediaFileTypeId) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MDMediaFileEntityRecord a, ENt_MDMediaFileEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MDMediaFileEntityRecord)) return false;
			return (this == (ENt_MDMediaFileEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMediaFileTypeId.GetHashCode()
				^ ssName.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MDMediaFileEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaFileTypeId = 0;
			_ssName = "";
			_ssDescription = "";
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMediaFileTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaFileTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaFileTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MDMediaFileEntityRecord Duplicate() {
			ENt_MDMediaFileEntityRecord t;
			t._ssMediaFileTypeId = this._ssMediaFileTypeId;
			t._ssName = this._ssName;
			t._ssDescription = this._ssDescription;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaFileTypeId")) VarValue.AppendAttribute(recordElem, "MediaFileTypeId", ssMediaFileTypeId, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "MediaFileTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mediafiletypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaFileTypeId")) variable.Value = ssMediaFileTypeId; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaFileTypeId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdName)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaFileTypeId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdName)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdDescription)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMediaFileTypeId) {
				return ssMediaFileTypeId;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssMediaFileTypeId = (int) other.AttributeGet(IdMediaFileTypeId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMediaFileTypeId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMediaFileTypeId);
			ssName = (string) other.AttributeGet(IdName);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdName);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdName);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MDMediaFileEntityRecord defaultStruct = new ENt_MDMediaFileEntityRecord(null);
			if (this.ssMediaFileTypeId != defaultStruct.ssMediaFileTypeId) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MDMediaFileEntityRecord

	public sealed partial class ENt_MUAlbumMediaEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUAlbumMedia]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "mediaid", "MediaId"
				}
				, { "albumid", "AlbumId"
				}
				, { "mediatypeid", "MediaTypeId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUAlbumMediaEntity

	/// <summary>
	/// Entity <code>ENt_MUAlbumMediaEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUAlbumMedia</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUAlbumMedia", "P13fdRAU506M7Od4Gg41xQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUAlbumMedia]", null)]
	[Serializable()]
	public partial struct ENt_MUAlbumMediaEntityRecord: ISerializable, ITypedRecord<ENt_MUAlbumMediaEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdMediaId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*or8YmfkZiECaZ5Rl9q+Hlg");
		private static readonly GlobalObjectKey IdAlbumId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*mv36xarEfEathLuQSZW0WA");
		private static readonly GlobalObjectKey IdMediaTypeId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*lTAiGM1ApEqJI2ZPRZi_Pg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*tITniKtrQE+CIffbjlWndg");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*qZZGj01lPUuPiPxYQIG9kQ");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MediaId")]
		private long _ssMediaId;
		public long ssMediaId {
			get {
				return _ssMediaId;
			}
			set {
				if ((_ssMediaId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssMediaId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("AlbumId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("AlbumId")]
		private int _ssAlbumId;
		public int ssAlbumId {
			get {
				return _ssAlbumId;
			}
			set {
				if ((_ssAlbumId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssAlbumId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("MediaTypeId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("MediaTypeId")]
		private int _ssMediaTypeId;
		public int ssMediaTypeId {
			get {
				return _ssMediaTypeId;
			}
			set {
				if ((_ssMediaTypeId!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssMediaTypeId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[4]) {
					ChangedAttributes[4] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUAlbumMediaEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaId = 0L;
			_ssAlbumId = 0;
			_ssMediaTypeId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssMediaId = r.ReadEntityReferenceLongInteger(index++, "t_MUAlbumMedia.MediaId", 0L);
			ssAlbumId = r.ReadEntityReference(index++, "t_MUAlbumMedia.AlbumId", 0);
			ssMediaTypeId = r.ReadEntityReference(index++, "t_MUAlbumMedia.MediaTypeId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUAlbumMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUAlbumMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(5, false);
			OptimizedAttributes = new BitArray(5, false);
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
		public void ReadIM(ENt_MUAlbumMediaEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUAlbumMediaEntityRecord a, ENt_MUAlbumMediaEntityRecord b) {
			if (a.ssMediaId != b.ssMediaId) return false;
			if (a.ssAlbumId != b.ssAlbumId) return false;
			if (a.ssMediaTypeId != b.ssMediaTypeId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUAlbumMediaEntityRecord a, ENt_MUAlbumMediaEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUAlbumMediaEntityRecord)) return false;
			return (this == (ENt_MUAlbumMediaEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssMediaId.GetHashCode()
				^ ssAlbumId.GetHashCode()
				^ ssMediaTypeId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUAlbumMediaEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(5, true);
			OptimizedAttributes = new BitArray(5, false);
			_ssMediaId = 0L;
			_ssAlbumId = 0;
			_ssMediaTypeId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssMediaId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssAlbumId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssAlbumId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssAlbumId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssMediaTypeId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssMediaTypeId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssMediaTypeId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUAlbumMediaEntityRecord Duplicate() {
			ENt_MUAlbumMediaEntityRecord t;
			t._ssMediaId = this._ssMediaId;
			t._ssAlbumId = this._ssAlbumId;
			t._ssMediaTypeId = this._ssMediaTypeId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(5);
			t.OptimizedAttributes = new BitArray(5);
			for (int i = 0; i < 5; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaId")) VarValue.AppendAttribute(recordElem, "MediaId", ssMediaId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "MediaId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AlbumId")) VarValue.AppendAttribute(recordElem, "AlbumId", ssAlbumId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "AlbumId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".MediaTypeId")) VarValue.AppendAttribute(recordElem, "MediaTypeId", ssMediaTypeId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "MediaTypeId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "mediaid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaId")) variable.Value = ssMediaId; else variable.Optimized = true;
			} else if (head == "albumid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AlbumId")) variable.Value = ssAlbumId; else variable.Optimized = true;
			} else if (head == "mediatypeid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".MediaTypeId")) variable.Value = ssMediaTypeId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdAlbumId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdMediaTypeId)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdMediaId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdAlbumId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdMediaTypeId)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[3];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[4];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdMediaId) {
				return ssMediaId;
			} else if (key == IdAlbumId) {
				return ssAlbumId;
			} else if (key == IdMediaTypeId) {
				return ssMediaTypeId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(5);
			OptimizedAttributes = new BitArray(5);
			if (other == null) return;
			ssMediaId = (long) other.AttributeGet(IdMediaId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdMediaId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdMediaId);
			ssAlbumId = (int) other.AttributeGet(IdAlbumId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdAlbumId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdAlbumId);
			ssMediaTypeId = (int) other.AttributeGet(IdMediaTypeId);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdMediaTypeId);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdMediaTypeId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[4] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[4] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUAlbumMediaEntityRecord defaultStruct = new ENt_MUAlbumMediaEntityRecord(null);
			if (this.ssMediaId != defaultStruct.ssMediaId) return false;
			if (this.ssAlbumId != defaultStruct.ssAlbumId) return false;
			if (this.ssMediaTypeId != defaultStruct.ssMediaTypeId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUAlbumMediaEntityRecord

	public sealed partial class ENt_MUArtistEventEntity {
		public static string LocalViewName(int? tenant, string locale) {
			return ViewName(null, locale);
		}
		public static string ViewName(int? tenant, string locale) {
			return "[dbo].[t_MUArtistEvent]";
		}
		public static System.Collections.Generic.Dictionary<string, string> AttributesToDatabaseNamesMap() {
			return new System.Collections.Generic.Dictionary<string, string>() {
				{ "eventid", "EventId"
				}
				, { "artistid", "ArtistId"
				}
				, { "insertdate", "InsertDate"
				}
				, { "updatedate", "UpdateDate"
				}
			};
		}
	} // ENt_MUArtistEventEntity

	/// <summary>
	/// Entity <code>ENt_MUArtistEventEntityRecord</code> that represents the Service Studio entity
	///  <code>t_MUArtistEvent</code> <p> Description: </p>
	/// </summary>
	[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityRecordDetails("t_MUArtistEvent", "dVJZV_hrO0upA5wrcncDoQ", "oJe9tylD_EGUBlO4A46FUA", 0, "[dbo].[t_MUArtistEvent]", null)]
	[Serializable()]
	public partial struct ENt_MUArtistEventEntityRecord: ISerializable, ITypedRecord<ENt_MUArtistEventEntityRecord>, ISimpleRecord {
		private static readonly GlobalObjectKey IdEventId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*k3p0fzysnkSUqPYteggEmg");
		private static readonly GlobalObjectKey IdArtistId = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*fwlJfzhdPkulQNMcaFfWAg");
		private static readonly GlobalObjectKey IdInsertDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*7M+2npsu9USdyK42IoDraw");
		private static readonly GlobalObjectKey IdUpdateDate = GlobalObjectKey.Parse("oJe9tylD_EGUBlO4A46FUA*EtEcVR1y50aeOu7IiIP48A");

		public static void EnsureInitialized() {}
		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("EventId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("EventId")]
		private long _ssEventId;
		public long ssEventId {
			get {
				return _ssEventId;
			}
			set {
				if ((_ssEventId!=value) || OptimizedAttributes[0]) {
					ChangedAttributes[0] = true;
					_ssEventId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("ArtistId", 0, false, false, true, true)]
		[System.Xml.Serialization.XmlElement("ArtistId")]
		private int _ssArtistId;
		public int ssArtistId {
			get {
				return _ssArtistId;
			}
			set {
				if ((_ssArtistId!=value) || OptimizedAttributes[1]) {
					ChangedAttributes[1] = true;
					_ssArtistId = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("InsertDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("InsertDate")]
		private DateTime _ssInsertDate;
		public DateTime ssInsertDate {
			get {
				return _ssInsertDate;
			}
			set {
				if ((_ssInsertDate!=value) || OptimizedAttributes[2]) {
					ChangedAttributes[2] = true;
					_ssInsertDate = value;
				}
			}
		}

		[OutSystems.HubEdition.RuntimePlatform.MetaInformation.EntityAttributeDetails("UpdateDate", 0, false, false, false, true)]
		[System.Xml.Serialization.XmlElement("UpdateDate")]
		private DateTime _ssUpdateDate;
		public DateTime ssUpdateDate {
			get {
				return _ssUpdateDate;
			}
			set {
				if ((_ssUpdateDate!=value) || OptimizedAttributes[3]) {
					ChangedAttributes[3] = true;
					_ssUpdateDate = value;
				}
			}
		}


		public BitArray ChangedAttributes;

		public BitArray OptimizedAttributes;

		public ENt_MUArtistEventEntityRecord(params string[] dummy) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssEventId = 0L;
			_ssArtistId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssEventId = r.ReadEntityReferenceLongInteger(index++, "t_MUArtistEvent.EventId", 0L);
			ssArtistId = r.ReadEntityReference(index++, "t_MUArtistEvent.ArtistId", 0);
			ssInsertDate = r.ReadDateTime(index++, "t_MUArtistEvent.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ssUpdateDate = r.ReadDateTime(index++, "t_MUArtistEvent.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0));
			ChangedAttributes = new BitArray(4, false);
			OptimizedAttributes = new BitArray(4, false);
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
		public void ReadIM(ENt_MUArtistEventEntityRecord r) {
			this = r;
		}


		public static bool operator == (ENt_MUArtistEventEntityRecord a, ENt_MUArtistEventEntityRecord b) {
			if (a.ssEventId != b.ssEventId) return false;
			if (a.ssArtistId != b.ssArtistId) return false;
			if (a.ssInsertDate != b.ssInsertDate) return false;
			if (a.ssUpdateDate != b.ssUpdateDate) return false;
			return true;
		}

		public static bool operator != (ENt_MUArtistEventEntityRecord a, ENt_MUArtistEventEntityRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(ENt_MUArtistEventEntityRecord)) return false;
			return (this == (ENt_MUArtistEventEntityRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEventId.GetHashCode()
				^ ssArtistId.GetHashCode()
				^ ssInsertDate.GetHashCode()
				^ ssUpdateDate.GetHashCode()
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

		public ENt_MUArtistEventEntityRecord(SerializationInfo info, StreamingContext context) {
			ChangedAttributes = new BitArray(4, true);
			OptimizedAttributes = new BitArray(4, false);
			_ssEventId = 0L;
			_ssArtistId = 0;
			_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
			_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("_ssEventId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssEventId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssEventId = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssArtistId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssArtistId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssArtistId = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssInsertDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssInsertDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssInsertDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("_ssUpdateDate", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named '_ssUpdateDate' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				_ssUpdateDate = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public ENt_MUArtistEventEntityRecord Duplicate() {
			ENt_MUArtistEventEntityRecord t;
			t._ssEventId = this._ssEventId;
			t._ssArtistId = this._ssArtistId;
			t._ssInsertDate = this._ssInsertDate;
			t._ssUpdateDate = this._ssUpdateDate;
			t.ChangedAttributes = new BitArray(4);
			t.OptimizedAttributes = new BitArray(4);
			for (int i = 0; i < 4; i++) {
				t.ChangedAttributes[i] = ChangedAttributes[i];
				t.OptimizedAttributes[i] = OptimizedAttributes[i];
			}
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Entity");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EventId")) VarValue.AppendAttribute(recordElem, "EventId", ssEventId, detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "EventId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.AppendAttribute(recordElem, "ArtistId", ssArtistId, detailLevel, TypeKind.EntityReference); else VarValue.AppendOptimizedAttribute(recordElem, "ArtistId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.AppendAttribute(recordElem, "InsertDate", ssInsertDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "InsertDate");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.AppendAttribute(recordElem, "UpdateDate", ssUpdateDate, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "UpdateDate");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "eventid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EventId")) variable.Value = ssEventId; else variable.Optimized = true;
			} else if (head == "artistid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ArtistId")) variable.Value = ssArtistId; else variable.Optimized = true;
			} else if (head == "insertdate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".InsertDate")) variable.Value = ssInsertDate; else variable.Optimized = true;
			} else if (head == "updatedate") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdateDate")) variable.Value = ssUpdateDate; else variable.Optimized = true;
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventId)) {
				return ChangedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return ChangedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return ChangedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return ChangedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			if (key.Equals(IdEventId)) {
				return OptimizedAttributes[0];
			} else if (key.Equals(IdArtistId)) {
				return OptimizedAttributes[1];
			} else if (key.Equals(IdInsertDate)) {
				return OptimizedAttributes[2];
			} else if (key.Equals(IdUpdateDate)) {
				return OptimizedAttributes[3];
			} else {
				throw new Exception("Invalid key");
			}
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdEventId) {
				return ssEventId;
			} else if (key == IdArtistId) {
				return ssArtistId;
			} else if (key == IdInsertDate) {
				return ssInsertDate;
			} else if (key == IdUpdateDate) {
				return ssUpdateDate;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			ChangedAttributes = new BitArray(4);
			OptimizedAttributes = new BitArray(4);
			if (other == null) return;
			ssEventId = (long) other.AttributeGet(IdEventId);
			ChangedAttributes[0] = other.ChangedAttributeGet(IdEventId);
			OptimizedAttributes[0] = other.OptimizedAttributeGet(IdEventId);
			ssArtistId = (int) other.AttributeGet(IdArtistId);
			ChangedAttributes[1] = other.ChangedAttributeGet(IdArtistId);
			OptimizedAttributes[1] = other.OptimizedAttributeGet(IdArtistId);
			ssInsertDate = (DateTime) other.AttributeGet(IdInsertDate);
			ChangedAttributes[2] = other.ChangedAttributeGet(IdInsertDate);
			OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInsertDate);
			ssUpdateDate = (DateTime) other.AttributeGet(IdUpdateDate);
			ChangedAttributes[3] = other.ChangedAttributeGet(IdUpdateDate);
			OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUpdateDate);
		}
		public bool IsDefault() {
			ENt_MUArtistEventEntityRecord defaultStruct = new ENt_MUArtistEventEntityRecord(null);
			if (this.ssEventId != defaultStruct.ssEventId) return false;
			if (this.ssArtistId != defaultStruct.ssArtistId) return false;
			if (this.ssInsertDate != defaultStruct.ssInsertDate) return false;
			if (this.ssUpdateDate != defaultStruct.ssUpdateDate) return false;
			return true;
		}
	} // ENt_MUArtistEventEntityRecord

} // OutSystems.NssMusicDBExternalData
