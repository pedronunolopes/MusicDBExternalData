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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUArtistMedia", key = "agOURwTH8UqHy1KEq4FQeQ", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUArtistMedia]", dbConnection = "")
public final class ENt_MUArtistMediaEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUArtistMediaEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdMediaId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*moZjltueV0qfObfI4DJAKA");
	private static final GlobalObjectKey IdArtistId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*C3BLXsZ1n0uQZLWNP0T29Q");
	private static final GlobalObjectKey IdMediaTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*oN7OEpgF8EyiRFkjJaKKLQ");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*QVMR4fkZXUOOXQsjY8grhQ");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*TQcBjHmRTE+z+ugAuE96Tg");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "MediaId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private long _ssMediaId;
	public long getSsMediaId() {
		return _ssMediaId;
	}
	public void setSsMediaId(long value) {
		if ((_ssMediaId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssMediaId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ArtistId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssArtistId;
	public int getSsArtistId() {
		return _ssArtistId;
	}
	public void setSsArtistId(int value) {
		if ((_ssArtistId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssArtistId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "MediaTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssMediaTypeId;
	public int getSsMediaTypeId() {
		return _ssMediaTypeId;
	}
	public void setSsMediaTypeId(int value) {
		if ((_ssMediaTypeId != value) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssMediaTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
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
	public ENt_MUArtistMediaEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(5, true);
		OptimizedAttributes = BitSetUtils.newInstance(5, false);
		_ssMediaId = 0L;
		_ssArtistId = 0;
		_ssMediaTypeId = 0;
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUArtistMediaRecord toRecord() {
		try {
			return new RCt_MUArtistMediaRecord(this);
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
		setSsMediaId(DataReaderUtils.readEntityReferenceLongInteger(r, index++, "t_MUArtistMedia.MediaId", 0L));
		setSsArtistId(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistMedia.ArtistId", 0));
		setSsMediaTypeId(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistMedia.MediaTypeId", 0));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUArtistMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUArtistMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(5, false);
		OptimizedAttributes = BitSetUtils.newInstance(5, false);
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
	public void readIM(ENt_MUArtistMediaEntityRecord r) throws Exception {
		this.setSsMediaId(r.getSsMediaId());
		this.setSsArtistId(r.getSsArtistId());
		this.setSsMediaTypeId(r.getSsMediaTypeId());
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
		if ((obj == null) || !(obj instanceof ENt_MUArtistMediaEntityRecord)) {
			return false;
		}
		ENt_MUArtistMediaEntityRecord b = (ENt_MUArtistMediaEntityRecord) obj;
		if (this.getSsMediaId() != b.getSsMediaId()) return false;
		if (this.getSsArtistId() != b.getSsArtistId()) return false;
		if (this.getSsMediaTypeId() != b.getSsMediaTypeId()) return false;
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
	public ENt_MUArtistMediaEntityRecord duplicate() throws Exception {
		ENt_MUArtistMediaEntityRecord t = new ENt_MUArtistMediaEntityRecord();
		t._ssMediaId = this._ssMediaId;
		t._ssArtistId = this._ssArtistId;
		t._ssMediaTypeId = this._ssMediaTypeId;
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(5);
		t.OptimizedAttributes = new BitSet(5);
		for (int i = 0; i < 5; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".MediaId")) VarValue.appendAttribute(recordElem, "MediaId", Long.valueOf(getSsMediaId()), detailLevel, TypeKind.EntityReferenceLongInteger); else VarValue.appendOptimizedAttribute(recordElem, "MediaId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.appendAttribute(recordElem, "ArtistId", Integer.valueOf(getSsArtistId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ArtistId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".MediaTypeId")) VarValue.appendAttribute(recordElem, "MediaTypeId", Integer.valueOf(getSsMediaTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "MediaTypeId");
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
		if (head.equals("mediaid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".MediaId")) variable.setValue(getSsMediaId()); else variable.setOptimized(true);
		} else if (head.equals("artistid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ArtistId")) variable.setValue(getSsArtistId()); else variable.setOptimized(true);
		} else if (head.equals("mediatypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".MediaTypeId")) variable.setValue(getSsMediaTypeId()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUArtistMediaEntityRecord t = (ENt_MUArtistMediaEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdArtistId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdMediaTypeId)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(4);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdArtistId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdMediaTypeId)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(4);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return getSsMediaId();
		} else if (key.equals(IdArtistId)) {
			return getSsArtistId();
		} else if (key.equals(IdMediaTypeId)) {
			return getSsMediaTypeId();
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
		ChangedAttributes = new BitSet(5);
		OptimizedAttributes = new BitSet(5);
		setSsMediaId(((Long) other.attributeGet(IdMediaId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdMediaId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdMediaId));
		setSsArtistId(((Integer) other.attributeGet(IdArtistId)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdArtistId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdArtistId));
		setSsMediaTypeId(((Integer) other.attributeGet(IdMediaTypeId)).intValue());
		ChangedAttributes.set(2, other.changedAttributeGet(IdMediaTypeId));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdMediaTypeId));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(4, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdUpdateDate));
	}
}
