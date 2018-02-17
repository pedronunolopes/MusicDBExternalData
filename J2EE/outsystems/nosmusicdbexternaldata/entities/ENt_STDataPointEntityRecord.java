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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_STDataPoint", key = "Hna7DFT2HkyjP+dKQxSlyA", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_STDataPoint]", dbConnection = "")
public final class ENt_STDataPointEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_STDataPointEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdDataPointId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*iYfCdVcbFkGptVQoM6SEBQ");
	private static final GlobalObjectKey IdDataSetId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*nvAqKI8T_UWBwUXcYpxOfQ");
	private static final GlobalObjectKey IdVersion = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*VESTXkN6ZU+GgQH3InBnjQ");
	private static final GlobalObjectKey IdDataPointTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*0eVQBcW+RUGQzqssAlv+CA");
	private static final GlobalObjectKey IdLabel = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*vE_dXgAaEEq3V6a85kDVzQ");
	private static final GlobalObjectKey IdValue = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*_4zbDIVFXkKBAFKiwJ6dnQ");
	private static final GlobalObjectKey IdReferenceDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*T0o95_OYVkikDWrjoZfXdA");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*0gK42qeprESJCJtjnDKwqw");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*ZxrnjVTwIEe+I3t18MX07A");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataPointId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssDataPointId;
	public long getSsDataPointId() {
		return _ssDataPointId;
	}
	public void setSsDataPointId(long value) {
		if ((_ssDataPointId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(9, true);
			_ssDataPointId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataSetId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private long _ssDataSetId;
	public long getSsDataSetId() {
		return _ssDataSetId;
	}
	public void setSsDataSetId(long value) {
		if ((_ssDataSetId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssDataSetId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Version", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssVersion;
	public int getSsVersion() {
		return _ssVersion;
	}
	public void setSsVersion(int value) {
		if ((_ssVersion != value) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssVersion = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "DataPointTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssDataPointTypeId;
	public int getSsDataPointTypeId() {
		return _ssDataPointTypeId;
	}
	public void setSsDataPointTypeId(int value) {
		if ((_ssDataPointTypeId != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssDataPointTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Label", length=50, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssLabel;
	public String getSsLabel() {
		return _ssLabel;
	}
	public void setSsLabel(String value) {
		if ((!_ssLabel.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssLabel = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Value", length=18, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private BigDecimal _ssValue;
	public BigDecimal getSsValue() {
		return _ssValue;
	}
	public void setSsValue(BigDecimal value) {
		if (DecimalUtils.different(_ssValue, value) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssValue = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ReferenceDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssReferenceDate;
	public DateTime getSsReferenceDate() {
		return _ssReferenceDate;
	}
	public void setSsReferenceDate(DateTime value) {
		if ((!_ssReferenceDate.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
			_ssReferenceDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(7)) {
			ChangedAttributes.set(7, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(8)) {
			ChangedAttributes.set(8, true);
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
	public ENt_STDataPointEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(9, true);
		OptimizedAttributes = BitSetUtils.newInstance(9, false);
		_ssDataPointId = 0L;
		_ssDataSetId = 0L;
		_ssVersion = 0;
		_ssDataPointTypeId = 0;
		_ssLabel = "";
		_ssValue = BigDecimal.ZERO;
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
	public RCt_STDataPointRecord toRecord() {
		try {
			return new RCt_STDataPointRecord(this);
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
		setSsDataPointId(DataReaderUtils.readLongInteger(r, index++, "t_STDataPoint.DataPointId", 0L));
		setSsDataSetId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_STDataPoint.DataSetId", 0L));
		setSsVersion(DataReaderUtils.readEntityReference(r, index++, "t_STDataPoint.Version", 0));
		setSsDataPointTypeId(DataReaderUtils.readEntityReference(r, index++, "t_STDataPoint.DataPointTypeId", 0));
		setSsLabel(DataReaderUtils.readText(r, index++, "t_STDataPoint.Label", ""));
		setSsValue(DataReaderUtils.readDecimal(r, index++, "t_STDataPoint.Value", BigDecimal.ZERO));
		setSsReferenceDate(DataReaderUtils.readDateTime(r, index++, "t_STDataPoint.ReferenceDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_STDataPoint.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_STDataPoint.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(9, false);
		OptimizedAttributes = BitSetUtils.newInstance(9, false);
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
	public void readIM(ENt_STDataPointEntityRecord r) throws Exception {
		this.setSsDataPointId(r.getSsDataPointId());
		this.setSsDataSetId(r.getSsDataSetId());
		this.setSsVersion(r.getSsVersion());
		this.setSsDataPointTypeId(r.getSsDataPointTypeId());
		this.setSsLabel(r.getSsLabel());
		this.setSsValue(r.getSsValue());
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
		if ((obj == null) || !(obj instanceof ENt_STDataPointEntityRecord)) {
			return false;
		}
		ENt_STDataPointEntityRecord b = (ENt_STDataPointEntityRecord) obj;
		if (this.getSsDataPointId() != b.getSsDataPointId()) return false;
		if (this.getSsDataSetId() != b.getSsDataSetId()) return false;
		if (this.getSsVersion() != b.getSsVersion()) return false;
		if (this.getSsDataPointTypeId() != b.getSsDataPointTypeId()) return false;
		if (!this.getSsLabel().equals(b.getSsLabel())) return false;
		if (!this.getSsValue().equals(b.getSsValue())) return false;
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
			return super.hashCode() ^ getSsLabel().hashCode() ^ getSsValue().hashCode() ^ getSsReferenceDate().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_STDataPointEntityRecord duplicate() throws Exception {
		ENt_STDataPointEntityRecord t = new ENt_STDataPointEntityRecord();
		t._ssDataPointId = this._ssDataPointId;
		t._ssDataSetId = this._ssDataSetId;
		t._ssVersion = this._ssVersion;
		t._ssDataPointTypeId = this._ssDataPointTypeId;
		t._ssLabel = this._ssLabel;
		t._ssValue = this._ssValue;
		t._ssReferenceDate = this._ssReferenceDate;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(9);
		t.OptimizedAttributes = new BitSet(9);
		for (int i = 0; i < 9; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataPointId")) VarValue.appendAttribute(recordElem, "DataPointId", Long.valueOf(getSsDataPointId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "DataPointId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataSetId")) VarValue.appendAttribute(recordElem, "DataSetId", Long.valueOf(getSsDataSetId()), detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.appendOptimizedAttribute(recordElem, "DataSetId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Version")) VarValue.appendAttribute(recordElem, "Version", Integer.valueOf(getSsVersion()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "Version");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".DataPointTypeId")) VarValue.appendAttribute(recordElem, "DataPointTypeId", Integer.valueOf(getSsDataPointTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "DataPointTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Label")) VarValue.appendAttribute(recordElem, "Label", getSsLabel(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Label");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Value")) VarValue.appendAttribute(recordElem, "Value", getSsValue(), detailLevel, TypeKind.Decimal); else VarValue.appendOptimizedAttribute(recordElem, "Value");
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
		if (head.equals("datapointid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataPointId")) variable.setValue(getSsDataPointId()); else variable.setOptimized(true);
		} else if (head.equals("datasetid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataSetId")) variable.setValue(getSsDataSetId()); else variable.setOptimized(true);
		} else if (head.equals("version")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Version")) variable.setValue(getSsVersion()); else variable.setOptimized(true);
		} else if (head.equals("datapointtypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".DataPointTypeId")) variable.setValue(getSsDataPointTypeId()); else variable.setOptimized(true);
		} else if (head.equals("label")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Label")) variable.setValue(getSsLabel()); else variable.setOptimized(true);
		} else if (head.equals("value")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Value")) variable.setValue(getSsValue()); else variable.setOptimized(true);
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
		ENt_STDataPointEntityRecord t = (ENt_STDataPointEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdDataSetId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdVersion)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdDataPointTypeId)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdLabel)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdValue)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdReferenceDate)) {
			return ChangedAttributes.get(6);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(7);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(8);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdDataSetId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdVersion)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdDataPointTypeId)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdLabel)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdValue)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdReferenceDate)) {
			return OptimizedAttributes.get(6);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(7);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(8);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdDataPointId)) {
			return getSsDataPointId();
		} else if (key.equals(IdDataSetId)) {
			return getSsDataSetId();
		} else if (key.equals(IdVersion)) {
			return getSsVersion();
		} else if (key.equals(IdDataPointTypeId)) {
			return getSsDataPointTypeId();
		} else if (key.equals(IdLabel)) {
			return getSsLabel();
		} else if (key.equals(IdValue)) {
			return getSsValue();
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
		ChangedAttributes = new BitSet(9);
		OptimizedAttributes = new BitSet(9);
		setSsDataPointId(((Long) other.attributeGet(IdDataPointId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdDataPointId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdDataPointId));
		setSsDataSetId(((Long) other.attributeGet(IdDataSetId)).longValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdDataSetId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdDataSetId));
		setSsVersion(((Integer) other.attributeGet(IdVersion)).intValue());
		ChangedAttributes.set(2, other.changedAttributeGet(IdVersion));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdVersion));
		setSsDataPointTypeId(((Integer) other.attributeGet(IdDataPointTypeId)).intValue());
		ChangedAttributes.set(3, other.changedAttributeGet(IdDataPointTypeId));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdDataPointTypeId));
		setSsLabel((String) other.attributeGet(IdLabel));
		ChangedAttributes.set(4, other.changedAttributeGet(IdLabel));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdLabel));
		setSsValue((BigDecimal) other.attributeGet(IdValue));
		ChangedAttributes.set(5, other.changedAttributeGet(IdValue));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdValue));
		setSsReferenceDate((DateTime) other.attributeGet(IdReferenceDate));
		ChangedAttributes.set(6, other.changedAttributeGet(IdReferenceDate));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdReferenceDate));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(7, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(7, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(8, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(8, other.optimizedAttributeGet(IdUpdateDate));
	}
}
