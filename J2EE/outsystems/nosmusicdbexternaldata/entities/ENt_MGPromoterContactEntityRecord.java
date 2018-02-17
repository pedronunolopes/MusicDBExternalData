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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MGPromoterContact", key = "zjyUJPaE8kq2GiYpU2cu2Q", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MGPromoterContact]", dbConnection = "")
public final class ENt_MGPromoterContactEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MGPromoterContactEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdPromoterId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*2aynqryif0qtNs+SAOM2TQ");
	private static final GlobalObjectKey IdContactId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*EZqIfK_IDUmA4pNv2JWgHw");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*oTwcl0AZuE+aGaMhnnkfgw");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*Tnb2pU+8MUmHN8mBaL7Kxw");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "PromoterId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssPromoterId;
	public int getSsPromoterId() {
		return _ssPromoterId;
	}
	public void setSsPromoterId(int value) {
		if ((_ssPromoterId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssPromoterId = value;
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
	public ENt_MGPromoterContactEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(4, true);
		OptimizedAttributes = BitSetUtils.newInstance(4, false);
		_ssPromoterId = 0;
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
	public RCt_MGPromoterContactRecord toRecord() {
		try {
			return new RCt_MGPromoterContactRecord(this);
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
		setSsPromoterId(DataReaderUtils.readEntityReference(r, index++, "t_MGPromoterContact.PromoterId", 0));
		setSsContactId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_MGPromoterContact.ContactId", 0L));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MGPromoterContact.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MGPromoterContact.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
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
	public void readIM(ENt_MGPromoterContactEntityRecord r) throws Exception {
		this.setSsPromoterId(r.getSsPromoterId());
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
		if ((obj == null) || !(obj instanceof ENt_MGPromoterContactEntityRecord)) {
			return false;
		}
		ENt_MGPromoterContactEntityRecord b = (ENt_MGPromoterContactEntityRecord) obj;
		if (this.getSsPromoterId() != b.getSsPromoterId()) return false;
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
	public ENt_MGPromoterContactEntityRecord duplicate() throws Exception {
		ENt_MGPromoterContactEntityRecord t = new ENt_MGPromoterContactEntityRecord();
		t._ssPromoterId = this._ssPromoterId;
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".PromoterId")) VarValue.appendAttribute(recordElem, "PromoterId", Integer.valueOf(getSsPromoterId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "PromoterId");
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
		if (head.equals("promoterid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".PromoterId")) variable.setValue(getSsPromoterId()); else variable.setOptimized(true);
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
		ENt_MGPromoterContactEntityRecord t = (ENt_MGPromoterContactEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdPromoterId)) {
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
		if (key.equals(IdPromoterId)) {
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
		if (key.equals(IdPromoterId)) {
			return getSsPromoterId();
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
		setSsPromoterId(((Integer) other.attributeGet(IdPromoterId)).intValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdPromoterId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdPromoterId));
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
