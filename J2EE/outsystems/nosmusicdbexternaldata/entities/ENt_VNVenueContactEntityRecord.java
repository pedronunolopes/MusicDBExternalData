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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_VNVenueContact", key = "Q5OgAXXhYUauXRik0EIr0w", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_VNVenueContact]", dbConnection = "")
public final class ENt_VNVenueContactEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_VNVenueContactEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdVenueId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*Nual1PNE6Ue6cL17Nr8QtA");
	private static final GlobalObjectKey IdContactId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*3tKpek3qVEuHrlPvJNf_zQ");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*VRWtp99BgkilQksbrpRqZg");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*L17LJN5Vw0aLYWLU81Jyig");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "VenueId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private long _ssVenueId;
	public long getSsVenueId() {
		return _ssVenueId;
	}
	public void setSsVenueId(long value) {
		if ((_ssVenueId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssVenueId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ContactId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private long _ssContactId;
	public long getSsContactId() {
		return _ssContactId;
	}
	public void setSsContactId(long value) {
		if ((_ssContactId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssContactId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
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
	public ENt_VNVenueContactEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(4, true);
		OptimizedAttributes = BitSetUtils.newInstance(4, false);
		_ssVenueId = 0L;
		_ssContactId = 0L;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_VNVenueContactRecord toRecord() {
		try {
			return new RCt_VNVenueContactRecord(this);
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
		setSsVenueId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_VNVenueContact.VenueId", 0L));
		setSsContactId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_VNVenueContact.ContactId", 0L));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_VNVenueContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_VNVenueContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(4, false);
		OptimizedAttributes = BitSetUtils.newInstance(4, false);
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
	public void readIM(ENt_VNVenueContactEntityRecord r) throws Exception {
		this.setSsVenueId(r.getSsVenueId());
		this.setSsContactId(r.getSsContactId());
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
		if ((obj == null) || !(obj instanceof ENt_VNVenueContactEntityRecord)) {
			return false;
		}
		ENt_VNVenueContactEntityRecord b = (ENt_VNVenueContactEntityRecord) obj;
		if (this.getSsVenueId() != b.getSsVenueId()) return false;
		if (this.getSsContactId() != b.getSsContactId()) return false;
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
			return super.hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_VNVenueContactEntityRecord duplicate() throws Exception {
		ENt_VNVenueContactEntityRecord t = new ENt_VNVenueContactEntityRecord();
		t._ssVenueId = this._ssVenueId;
		t._ssContactId = this._ssContactId;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(4);
		t.OptimizedAttributes = new BitSet(4);
		for (int i = 0; i < 4; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".VenueId")) VarValue.appendAttribute(recordElem, "VenueId", Long.valueOf(getSsVenueId()), detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.appendOptimizedAttribute(recordElem, "VenueId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ContactId")) VarValue.appendAttribute(recordElem, "ContactId", Long.valueOf(getSsContactId()), detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.appendOptimizedAttribute(recordElem, "ContactId");
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
		if (head.equals("venueid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".VenueId")) variable.setValue(getSsVenueId()); else variable.setOptimized(true);
		} else if (head.equals("contactid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ContactId")) variable.setValue(getSsContactId()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_VNVenueContactEntityRecord t = (ENt_VNVenueContactEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdContactId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(3);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdContactId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(3);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdVenueId)) {
			return getSsVenueId();
		} else if (key.equals(IdContactId)) {
			return getSsContactId();
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
		ChangedAttributes = new BitSet(4);
		OptimizedAttributes = new BitSet(4);
		setSsVenueId(((Long) other.attributeGet(IdVenueId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdVenueId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdVenueId));
		setSsContactId(((Long) other.attributeGet(IdContactId)).longValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdContactId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdContactId));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(2, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdUpdateDate));
	}
}
