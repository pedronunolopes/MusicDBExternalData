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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_STDataSet", key = "xw_YU8LIFkuTQNLWLP7YVQ", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_STDataSet]", dbConnection = "")
public final class ENt_STDataSetEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_STDataSetEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdDataSetId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*YMz8lQqMp0mh7NSqiA5jnQ");
	private static final GlobalObjectKey IdVersion = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*fGHeLFwN3UG7g5tac0SskQ");
	private static final GlobalObjectKey IdDataSetTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*798CcWDI_U2g_M9tXAX6Dw");
	private static final GlobalObjectKey IdReferenceDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*BoXQnlr5CUm0qHvAVLJAFg");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*rejv7YtfPkiVw64V1MCfuw");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*v7vDDLQf8kWMCxtHEsmaSA");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataSetId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private long _ssDataSetId;
	public long getSsDataSetId() {
		return _ssDataSetId;
	}
	public void setSsDataSetId(long value) {
		if ((_ssDataSetId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssDataSetId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Version", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private int _ssVersion;
	public int getSsVersion() {
		return _ssVersion;
	}
	public void setSsVersion(int value) {
		if ((_ssVersion != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssVersion = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataSetTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssDataSetTypeId;
	public int getSsDataSetTypeId() {
		return _ssDataSetTypeId;
	}
	public void setSsDataSetTypeId(int value) {
		if ((_ssDataSetTypeId != value) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssDataSetTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ReferenceDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssReferenceDate;
	public DateTime getSsReferenceDate() {
		return _ssReferenceDate;
	}
	public void setSsReferenceDate(DateTime value) {
		if ((!_ssReferenceDate.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssReferenceDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
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
	public ENt_STDataSetEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(6, true);
		OptimizedAttributes = BitSetUtils.newInstance(6, false);
		_ssDataSetId = 0L;
		_ssVersion = 0;
		_ssDataSetTypeId = 0;
		_ssReferenceDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_STDataSetRecord toRecord() {
		try {
			return new RCt_STDataSetRecord(this);
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
		setSsDataSetId(DataReaderUtils.readLongInteger(r, index++, "t_STDataSet.DataSetId", 0L));
		setSsVersion(DataReaderUtils.readInteger(r, index++, "t_STDataSet.Version", 0));
		setSsDataSetTypeId(DataReaderUtils.readEntityReference(r, index++, "t_STDataSet.DataSetTypeId", 0));
		setSsReferenceDate(DataReaderUtils.readDateTime(r, index++, "t_STDataSet.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_STDataSet.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_STDataSet.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(6, false);
		OptimizedAttributes = BitSetUtils.newInstance(6, false);
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
	public void readIM(ENt_STDataSetEntityRecord r) throws Exception {
		this.setSsDataSetId(r.getSsDataSetId());
		this.setSsVersion(r.getSsVersion());
		this.setSsDataSetTypeId(r.getSsDataSetTypeId());
		this.setSsReferenceDate(r.getSsReferenceDate());
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
		if ((obj == null) || !(obj instanceof ENt_STDataSetEntityRecord)) {
			return false;
		}
		ENt_STDataSetEntityRecord b = (ENt_STDataSetEntityRecord) obj;
		if (this.getSsDataSetId() != b.getSsDataSetId()) return false;
		if (this.getSsVersion() != b.getSsVersion()) return false;
		if (this.getSsDataSetTypeId() != b.getSsDataSetTypeId()) return false;
		if (!this.getSsReferenceDate().equals(b.getSsReferenceDate())) return false;
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
			return super.hashCode() ^ getSsReferenceDate().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_STDataSetEntityRecord duplicate() throws Exception {
		ENt_STDataSetEntityRecord t = new ENt_STDataSetEntityRecord();
		t._ssDataSetId = this._ssDataSetId;
		t._ssVersion = this._ssVersion;
		t._ssDataSetTypeId = this._ssDataSetTypeId;
		t._ssReferenceDate = this._ssReferenceDate;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(6);
		t.OptimizedAttributes = new BitSet(6);
		for (int i = 0; i < 6; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataSetId")) VarValue.appendAttribute(recordElem, "DataSetId", Long.valueOf(getSsDataSetId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "DataSetId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Version")) VarValue.appendAttribute(recordElem, "Version", Integer.valueOf(getSsVersion()), detailLevel, TypeKind.Integer); else VarValue.appendOptimizedAttribute(recordElem, "Version");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataSetTypeId")) VarValue.appendAttribute(recordElem, "DataSetTypeId", Integer.valueOf(getSsDataSetTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "DataSetTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ReferenceDate")) VarValue.appendAttribute(recordElem, "ReferenceDate", getSsReferenceDate(), detailLevel, TypeKind.DateTime); else VarValue.appendOptimizedAttribute(recordElem, "ReferenceDate");
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
		if (head.equals("datasetid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataSetId")) variable.setValue(getSsDataSetId()); else variable.setOptimized(true);
		} else if (head.equals("version")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Version")) variable.setValue(getSsVersion()); else variable.setOptimized(true);
		} else if (head.equals("datasettypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataSetTypeId")) variable.setValue(getSsDataSetTypeId()); else variable.setOptimized(true);
		} else if (head.equals("referencedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ReferenceDate")) variable.setValue(getSsReferenceDate()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_STDataSetEntityRecord t = (ENt_STDataSetEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataSetId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdVersion)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdDataSetTypeId)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdReferenceDate)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(5);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataSetId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdVersion)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdDataSetTypeId)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdReferenceDate)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(5);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataSetId)) {
			return getSsDataSetId();
		} else if (key.equals(IdVersion)) {
			return getSsVersion();
		} else if (key.equals(IdDataSetTypeId)) {
			return getSsDataSetTypeId();
		} else if (key.equals(IdReferenceDate)) {
			return getSsReferenceDate();
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
		ChangedAttributes = new BitSet(6);
		OptimizedAttributes = new BitSet(6);
		setSsDataSetId(((Long) other.attributeGet(IdDataSetId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdDataSetId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdDataSetId));
		setSsVersion(((Integer) other.attributeGet(IdVersion)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdVersion));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdVersion));
		setSsDataSetTypeId(((Integer) other.attributeGet(IdDataSetTypeId)).intValue());
		ChangedAttributes.set(2, other.changedAttributeGet(IdDataSetTypeId));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdDataSetTypeId));
		setSsReferenceDate((DateTime) other.attributeGet(IdReferenceDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdReferenceDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdReferenceDate));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(4, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(5, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdUpdateDate));
	}
}
