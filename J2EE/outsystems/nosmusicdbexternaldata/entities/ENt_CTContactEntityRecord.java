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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_CTContact", key = "DmdbMH1frE2rkt6rwGK76g", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_CTContact]", dbConnection = "")
public final class ENt_CTContactEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_CTContactEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdContactId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*ck15wHIdnEqL18RsIwoQug");
	private static final GlobalObjectKey IdContactTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*+LhDRkGYvk+yxuG_3Qp8zw");
	private static final GlobalObjectKey IdField1 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*ruwm8xgrsEeACuFxL6VgCg");
	private static final GlobalObjectKey IdField2 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*4ja6Ovz41EeLnQD1O+Q7NA");
	private static final GlobalObjectKey IdField3 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*SuhM14rk6U+GsCrNZr_uCw");
	private static final GlobalObjectKey IdCountryId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*nqS+7_CPbEy2QgrFq2v9aQ");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*4ysjB+bDUUWVXTHzZlmaqA");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*c_tYQOs75EaT0v2F607FTQ");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ContactId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssContactId;
	public long getSsContactId() {
		return _ssContactId;
	}
	public void setSsContactId(long value) {
		if ((_ssContactId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(8, true);
			_ssContactId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ContactTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssContactTypeId;
	public int getSsContactTypeId() {
		return _ssContactTypeId;
	}
	public void setSsContactTypeId(int value) {
		if ((_ssContactTypeId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssContactTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Field1", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private String _ssField1;
	public String getSsField1() {
		return _ssField1;
	}
	public void setSsField1(String value) {
		if ((!_ssField1.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssField1 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Field2", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssField2;
	public String getSsField2() {
		return _ssField2;
	}
	public void setSsField2(String value) {
		if ((!_ssField2.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssField2 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Field3", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssField3;
	public String getSsField3() {
		return _ssField3;
	}
	public void setSsField3(String value) {
		if ((!_ssField3.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssField3 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "CountryId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=false)
	private int _ssCountryId;
	public int getSsCountryId() {
		return _ssCountryId;
	}
	public void setSsCountryId(int value) {
		if ((_ssCountryId != value) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssCountryId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(7)) {
			ChangedAttributes.set(7, true);
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
	public ENt_CTContactEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(8, true);
		OptimizedAttributes = BitSetUtils.newInstance(8, false);
		_ssContactId = 0L;
		_ssContactTypeId = 0;
		_ssField1 = "";
		_ssField2 = "";
		_ssField3 = "";
		_ssCountryId = 0;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_CTContactRecord toRecord() {
		try {
			return new RCt_CTContactRecord(this);
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
		setSsContactId(DataReaderUtils.readLongInteger(r, index++, "t_CTContact.ContactId", 0L));
		setSsContactTypeId(DataReaderUtils.readEntityReference(r, index++, "t_CTContact.ContactTypeId", 0));
		setSsField1(DataReaderUtils.readText(r, index++, "t_CTContact.Field1", ""));
		setSsField2(DataReaderUtils.readText(r, index++, "t_CTContact.Field2", ""));
		setSsField3(DataReaderUtils.readText(r, index++, "t_CTContact.Field3", ""));
		setSsCountryId(DataReaderUtils.readEntityReference(r, index++, "t_CTContact.CountryId", 0));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_CTContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_CTContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(8, false);
		OptimizedAttributes = BitSetUtils.newInstance(8, false);
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
	public void readIM(ENt_CTContactEntityRecord r) throws Exception {
		this.setSsContactId(r.getSsContactId());
		this.setSsContactTypeId(r.getSsContactTypeId());
		this.setSsField1(r.getSsField1());
		this.setSsField2(r.getSsField2());
		this.setSsField3(r.getSsField3());
		this.setSsCountryId(r.getSsCountryId());
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
		if ((obj == null) || !(obj instanceof ENt_CTContactEntityRecord)) {
			return false;
		}
		ENt_CTContactEntityRecord b = (ENt_CTContactEntityRecord) obj;
		if (this.getSsContactId() != b.getSsContactId()) return false;
		if (this.getSsContactTypeId() != b.getSsContactTypeId()) return false;
		if (!this.getSsField1().equals(b.getSsField1())) return false;
		if (!this.getSsField2().equals(b.getSsField2())) return false;
		if (!this.getSsField3().equals(b.getSsField3())) return false;
		if (this.getSsCountryId() != b.getSsCountryId()) return false;
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
			return super.hashCode() ^ getSsField1().hashCode() ^ getSsField2().hashCode() ^ getSsField3().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_CTContactEntityRecord duplicate() throws Exception {
		ENt_CTContactEntityRecord t = new ENt_CTContactEntityRecord();
		t._ssContactId = this._ssContactId;
		t._ssContactTypeId = this._ssContactTypeId;
		t._ssField1 = this._ssField1;
		t._ssField2 = this._ssField2;
		t._ssField3 = this._ssField3;
		t._ssCountryId = this._ssCountryId;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(8);
		t.OptimizedAttributes = new BitSet(8);
		for (int i = 0; i < 8; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.appendAttribute(recordElem, "ContactId", Long.valueOf(getSsContactId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "ContactId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ContactTypeId")) VarValue.appendAttribute(recordElem, "ContactTypeId", Integer.valueOf(getSsContactTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ContactTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Field1")) VarValue.appendAttribute(recordElem, "Field1", getSsField1(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Field1");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Field2")) VarValue.appendAttribute(recordElem, "Field2", getSsField2(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Field2");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Field3")) VarValue.appendAttribute(recordElem, "Field3", getSsField3(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Field3");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.appendAttribute(recordElem, "CountryId", Integer.valueOf(getSsCountryId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "CountryId");
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
		if (head.equals("contactid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ContactId")) variable.setValue(getSsContactId()); else variable.setOptimized(true);
		} else if (head.equals("contacttypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ContactTypeId")) variable.setValue(getSsContactTypeId()); else variable.setOptimized(true);
		} else if (head.equals("field1")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Field1")) variable.setValue(getSsField1()); else variable.setOptimized(true);
		} else if (head.equals("field2")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Field2")) variable.setValue(getSsField2()); else variable.setOptimized(true);
		} else if (head.equals("field3")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Field3")) variable.setValue(getSsField3()); else variable.setOptimized(true);
		} else if (head.equals("countryid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".CountryId")) variable.setValue(getSsCountryId()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_CTContactEntityRecord t = (ENt_CTContactEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdContactId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdContactTypeId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdField1)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdField2)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdField3)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdCountryId)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(6);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(7);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdContactId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdContactTypeId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdField1)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdField2)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdField3)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdCountryId)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(6);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(7);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdContactId)) {
			return getSsContactId();
		} else if (key.equals(IdContactTypeId)) {
			return getSsContactTypeId();
		} else if (key.equals(IdField1)) {
			return getSsField1();
		} else if (key.equals(IdField2)) {
			return getSsField2();
		} else if (key.equals(IdField3)) {
			return getSsField3();
		} else if (key.equals(IdCountryId)) {
			return getSsCountryId();
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
		ChangedAttributes = new BitSet(8);
		OptimizedAttributes = new BitSet(8);
		setSsContactId(((Long) other.attributeGet(IdContactId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdContactId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdContactId));
		setSsContactTypeId(((Integer) other.attributeGet(IdContactTypeId)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdContactTypeId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdContactTypeId));
		setSsField1((String) other.attributeGet(IdField1));
		ChangedAttributes.set(2, other.changedAttributeGet(IdField1));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdField1));
		setSsField2((String) other.attributeGet(IdField2));
		ChangedAttributes.set(3, other.changedAttributeGet(IdField2));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdField2));
		setSsField3((String) other.attributeGet(IdField3));
		ChangedAttributes.set(4, other.changedAttributeGet(IdField3));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdField3));
		setSsCountryId(((Integer) other.attributeGet(IdCountryId)).intValue());
		ChangedAttributes.set(5, other.changedAttributeGet(IdCountryId));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdCountryId));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(6, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(7, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(7, other.optimizedAttributeGet(IdUpdateDate));
	}
}
