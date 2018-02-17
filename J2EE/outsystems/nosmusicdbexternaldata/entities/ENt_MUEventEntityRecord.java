package outsystems.nosmusicdbexternaldata.entities;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUEvent", key = "jtMuyiyt50qgkUAtLZz1WQ", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUEvent]", dbConnection = "")
public final class ENt_MUEventEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUEventEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdEventId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*KzZoc0htb0iwWoDoTrJQsA");
	private static final GlobalObjectKey IdEventTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*tpUVWaZ2hEG+zc_BSjt+iQ");
	private static final GlobalObjectKey IdName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*Mxmpj3o4aEuDgqFHw2GkgA");
	private static final GlobalObjectKey IdDescription = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*U3tbhiFvqEuL6qx0xL_NsA");
	private static final GlobalObjectKey IdVenueId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*rQlbAoPmJkWxB1ocpfiBvg");
	private static final GlobalObjectKey IdParentEventId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*fltOEbzE70W4BrDHsJ38SA");
	private static final GlobalObjectKey IdCity = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*vGc+jCf9R0qWsKvU9XoEKw");
	private static final GlobalObjectKey IdDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*t808Oy7o5EaKBJA+NsjVRw");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*MCQSxNmimEyONA2dct+YRQ");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*eSlNImJ1PkaCJUcMaTcZfg");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "EventId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssEventId;
	public long getSsEventId() {
		return _ssEventId;
	}
	public void setSsEventId(long value) {
		if ((_ssEventId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(10, true);
			_ssEventId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "EventTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssEventTypeId;
	public int getSsEventTypeId() {
		return _ssEventTypeId;
	}
	public void setSsEventTypeId(int value) {
		if ((_ssEventTypeId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssEventTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Name", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private String _ssName;
	public String getSsName() {
		return _ssName;
	}
	public void setSsName(String value) {
		if ((!_ssName.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssName = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Description", length=2000, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssDescription;
	public String getSsDescription() {
		return _ssDescription;
	}
	public void setSsDescription(String value) {
		if ((!_ssDescription.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssDescription = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "VenueId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private long _ssVenueId;
	public long getSsVenueId() {
		return _ssVenueId;
	}
	public void setSsVenueId(long value) {
		if ((_ssVenueId != value) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssVenueId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ParentEventId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private long _ssParentEventId;
	public long getSsParentEventId() {
		return _ssParentEventId;
	}
	public void setSsParentEventId(long value) {
		if ((_ssParentEventId != value) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssParentEventId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "City", length=200, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssCity;
	public String getSsCity() {
		return _ssCity;
	}
	public void setSsCity(String value) {
		if ((!_ssCity.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssCity = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Date", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private DateTime _ssDate;
	public DateTime getSsDate() {
		return _ssDate;
	}
	public void setSsDate(DateTime value) {
		if ((!_ssDate.equals(value)) || OptimizedAttributes.get(7)) {
			ChangedAttributes.set(7, true);
			_ssDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(8)) {
			ChangedAttributes.set(8, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(9)) {
			ChangedAttributes.set(9, true);
			_ssUpdateDate = value;
		}
	}


	public BitSet ChangedAttributes;
	public BitSet getChangedAttributes() {
		return ChangedAttributes;
	}

	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public ENt_MUEventEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(10, true);
		OptimizedAttributes = BitSetUtils.newInstance(10, false);
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

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUEventRecord toRecord() {
		try {
			return new RCt_MUEventRecord(this);
		} catch (Exception e) {
			return WrappedException.wrapExceptionIfNeeded(e);
		}
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[0];
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
		} else {
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[0];
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		setSsEventId(DataReaderUtils.readLongInteger(r, index++, "t_MUEvent.EventId", 0L));
		setSsEventTypeId(DataReaderUtils.readEntityReference(r, index++, "t_MUEvent.EventTypeId", 0));
		setSsName(DataReaderUtils.readText(r, index++, "t_MUEvent.Name", ""));
		setSsDescription(DataReaderUtils.readText(r, index++, "t_MUEvent.Description", ""));
		setSsVenueId(DataReaderUtils.readLongInteger(r, index++, "t_MUEvent.VenueId", 0L));
		setSsParentEventId(DataReaderUtils.readLongInteger(r, index++, "t_MUEvent.ParentEventId", 0L));
		setSsCity(DataReaderUtils.readText(r, index++, "t_MUEvent.City", ""));
		setSsDate(DataReaderUtils.readDateTime(r, index++, "t_MUEvent.Date", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUEvent.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUEvent.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(10, false);
		OptimizedAttributes = BitSetUtils.newInstance(10, false);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(ENt_MUEventEntityRecord r) throws Exception {
		this.setSsEventId(r.getSsEventId());
		this.setSsEventTypeId(r.getSsEventTypeId());
		this.setSsName(r.getSsName());
		this.setSsDescription(r.getSsDescription());
		this.setSsVenueId(r.getSsVenueId());
		this.setSsParentEventId(r.getSsParentEventId());
		this.setSsCity(r.getSsCity());
		this.setSsDate(r.getSsDate());
		this.setSsInsertDate(r.getSsInsertDate());
		this.setSsUpdateDate(r.getSsUpdateDate());
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof ENt_MUEventEntityRecord)) {
			return false;
		}
		ENt_MUEventEntityRecord b = (ENt_MUEventEntityRecord) obj;
		if (this.getSsEventId() != b.getSsEventId()) return false;
		if (this.getSsEventTypeId() != b.getSsEventTypeId()) return false;
		if (!this.getSsName().equals(b.getSsName())) return false;
		if (!this.getSsDescription().equals(b.getSsDescription())) return false;
		if (this.getSsVenueId() != b.getSsVenueId()) return false;
		if (this.getSsParentEventId() != b.getSsParentEventId()) return false;
		if (!this.getSsCity().equals(b.getSsCity())) return false;
		if (!this.getSsDate().equals(b.getSsDate())) return false;
		if (!this.getSsInsertDate().equals(b.getSsInsertDate())) return false;
		if (!this.getSsUpdateDate().equals(b.getSsUpdateDate())) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ getSsName().hashCode() ^ getSsDescription().hashCode() ^ getSsCity().hashCode() ^ getSsDate().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public ENt_MUEventEntityRecord duplicate() throws Exception {
		ENt_MUEventEntityRecord t = new ENt_MUEventEntityRecord();
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
		t.ChangedAttributes = new BitSet(10);
		t.OptimizedAttributes = new BitSet(10);
		for (int i = 0; i < 10; i++) {
			t.ChangedAttributes.set(i, ChangedAttributes.get(i));
			t.OptimizedAttributes.set(i, OptimizedAttributes.get(i));
		}
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Entity");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
			fieldName = fieldName.toLowerCase();
		}
		if (detailLevel > 0) {
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".EventId")) VarValue.appendAttribute(recordElem, "EventId", Long.valueOf(getSsEventId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "EventId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".EventTypeId")) VarValue.appendAttribute(recordElem, "EventTypeId", Integer.valueOf(getSsEventTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "EventTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Name")) VarValue.appendAttribute(recordElem, "Name", getSsName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Name");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Description")) VarValue.appendAttribute(recordElem, "Description", getSsDescription(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Description");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.appendAttribute(recordElem, "VenueId", Long.valueOf(getSsVenueId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "VenueId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ParentEventId")) VarValue.appendAttribute(recordElem, "ParentEventId", Long.valueOf(getSsParentEventId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "ParentEventId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".City")) VarValue.appendAttribute(recordElem, "City", getSsCity(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "City");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Date")) VarValue.appendAttribute(recordElem, "Date", getSsDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "Date");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".InsertDate")) VarValue.appendAttribute(recordElem, "InsertDate", getSsInsertDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "InsertDate");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".UpdateDate")) VarValue.appendAttribute(recordElem, "UpdateDate", getSsUpdateDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "UpdateDate");
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("eventid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".EventId")) variable.setValue(getSsEventId()); else variable.setOptimized(true);
		} else if (head.equals("eventtypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".EventTypeId")) variable.setValue(getSsEventTypeId()); else variable.setOptimized(true);
		} else if (head.equals("name")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Name")) variable.setValue(getSsName()); else variable.setOptimized(true);
		} else if (head.equals("description")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Description")) variable.setValue(getSsDescription()); else variable.setOptimized(true);
		} else if (head.equals("venueid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".VenueId")) variable.setValue(getSsVenueId()); else variable.setOptimized(true);
		} else if (head.equals("parenteventid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ParentEventId")) variable.setValue(getSsParentEventId()); else variable.setOptimized(true);
		} else if (head.equals("city")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".City")) variable.setValue(getSsCity()); else variable.setOptimized(true);
		} else if (head.equals("date")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Date")) variable.setValue(getSsDate()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUEventEntityRecord t = (ENt_MUEventEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdEventId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdEventTypeId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdName)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdDescription)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdVenueId)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdParentEventId)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdCity)) {
			return ChangedAttributes.get(6);
		} else if (key.equals(IdDate)) {
			return ChangedAttributes.get(7);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(8);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(9);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdEventId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdEventTypeId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdName)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdDescription)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdVenueId)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdParentEventId)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdCity)) {
			return OptimizedAttributes.get(6);
		} else if (key.equals(IdDate)) {
			return OptimizedAttributes.get(7);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(8);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(9);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdEventId)) {
			return getSsEventId();
		} else if (key.equals(IdEventTypeId)) {
			return getSsEventTypeId();
		} else if (key.equals(IdName)) {
			return getSsName();
		} else if (key.equals(IdDescription)) {
			return getSsDescription();
		} else if (key.equals(IdVenueId)) {
			return getSsVenueId();
		} else if (key.equals(IdParentEventId)) {
			return getSsParentEventId();
		} else if (key.equals(IdCity)) {
			return getSsCity();
		} else if (key.equals(IdDate)) {
			return getSsDate();
		} else if (key.equals(IdInsertDate)) {
			return getSsInsertDate();
		} else if (key.equals(IdUpdateDate)) {
			return getSsUpdateDate();
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ChangedAttributes = new BitSet(10);
		OptimizedAttributes = new BitSet(10);
		setSsEventId(((Long) other.attributeGet(IdEventId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdEventId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdEventId));
		setSsEventTypeId(((Integer) other.attributeGet(IdEventTypeId)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdEventTypeId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdEventTypeId));
		setSsName((String) other.attributeGet(IdName));
		ChangedAttributes.set(2, other.changedAttributeGet(IdName));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdName));
		setSsDescription((String) other.attributeGet(IdDescription));
		ChangedAttributes.set(3, other.changedAttributeGet(IdDescription));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdDescription));
		setSsVenueId(((Long) other.attributeGet(IdVenueId)).longValue());
		ChangedAttributes.set(4, other.changedAttributeGet(IdVenueId));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdVenueId));
		setSsParentEventId(((Long) other.attributeGet(IdParentEventId)).longValue());
		ChangedAttributes.set(5, other.changedAttributeGet(IdParentEventId));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdParentEventId));
		setSsCity((String) other.attributeGet(IdCity));
		ChangedAttributes.set(6, other.changedAttributeGet(IdCity));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdCity));
		setSsDate((DateTime) other.attributeGet(IdDate));
		ChangedAttributes.set(7, other.changedAttributeGet(IdDate));
		OptimizedAttributes.set(7, other.optimizedAttributeGet(IdDate));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(8, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(8, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(9, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(9, other.optimizedAttributeGet(IdUpdateDate));
	}
}
