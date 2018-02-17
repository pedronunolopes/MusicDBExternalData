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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MTMedia", key = "xeRLXMchgkKq8Mk2IK7NIw", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MTMedia]", dbConnection = "")
public final class ENt_MTMediaEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MTMediaEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdMediaId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*5oMmsJehkk+J7e226SqQYw");
	private static final GlobalObjectKey IdFileName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*NuLPX6fZr0iDSL_6OyR3jg");
	private static final GlobalObjectKey IdMimeType = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*bsr7ytnU1UWK4x8DpSsiFw");
	private static final GlobalObjectKey IdMediaFileTypeId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*QV9WrjD3T0yqgNmThF0Qrw");
	private static final GlobalObjectKey IdFileBinary = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*JN0WNxEfLUOleMhQHBiTLg");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*EmDcdW5RYkejX5l5Qs4VHg");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*fZgQIoZ13UieE8gJle8uWQ");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "MediaId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private long _ssMediaId;
	public long getSsMediaId() {
		return _ssMediaId;
	}
	public void setSsMediaId(long value) {
		if ((_ssMediaId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(7, true);
			_ssMediaId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "FileName", length=255, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssFileName;
	public String getSsFileName() {
		return _ssFileName;
	}
	public void setSsFileName(String value) {
		if ((!_ssFileName.equals(value)) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssFileName = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "MimeType", length=50, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssMimeType;
	public String getSsMimeType() {
		return _ssMimeType;
	}
	public void setSsMimeType(String value) {
		if ((!_ssMimeType.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssMimeType = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "MediaFileTypeId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssMediaFileTypeId;
	public int getSsMediaFileTypeId() {
		return _ssMediaFileTypeId;
	}
	public void setSsMediaFileTypeId(int value) {
		if ((_ssMediaFileTypeId != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssMediaFileTypeId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "FileBinary", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private byte[] _ssFileBinary;
	public byte[] getSsFileBinary() {
		return _ssFileBinary;
	}
	public void setSsFileBinary(byte[] value) {
		if ((_ssFileBinary != value) || OptimizedAttributes.get(4)) {
			ChangedAttributes.set(4, true);
			_ssFileBinary = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssInsertDate;
	public DateTime getSsInsertDate() {
		return _ssInsertDate;
	}
	public void setSsInsertDate(DateTime value) {
		if ((!_ssInsertDate.equals(value)) || OptimizedAttributes.get(5)) {
			ChangedAttributes.set(5, true);
			_ssInsertDate = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private DateTime _ssUpdateDate;
	public DateTime getSsUpdateDate() {
		return _ssUpdateDate;
	}
	public void setSsUpdateDate(DateTime value) {
		if ((!_ssUpdateDate.equals(value)) || OptimizedAttributes.get(6)) {
			ChangedAttributes.set(6, true);
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
	public ENt_MTMediaEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(7, true);
		OptimizedAttributes = BitSetUtils.newInstance(7, false);
		_ssMediaId = 0L;
		_ssFileName = "";
		_ssMimeType = "";
		_ssMediaFileTypeId = 0;
		_ssFileBinary = new byte[] {};
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MTMediaRecord toRecord() {
		try {
			return new RCt_MTMediaRecord(this);
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
		setSsMediaId(DataReaderUtils.readLongInteger(r, index++, "t_MTMedia.MediaId", 0L));
		setSsFileName(DataReaderUtils.readText(r, index++, "t_MTMedia.FileName", ""));
		setSsMimeType(DataReaderUtils.readText(r, index++, "t_MTMedia.MimeType", ""));
		setSsMediaFileTypeId(DataReaderUtils.readEntityReference(r, index++, "t_MTMedia.MediaFileTypeId", 0));
		setSsFileBinary(DataReaderUtils.readBinaryData(r, index++, "t_MTMedia.FileBinary", new byte[] {}));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MTMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MTMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		ChangedAttributes = BitSetUtils.newInstance(7, false);
		OptimizedAttributes = BitSetUtils.newInstance(7, false);
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
	public void readIM(ENt_MTMediaEntityRecord r) throws Exception {
		this.setSsMediaId(r.getSsMediaId());
		this.setSsFileName(r.getSsFileName());
		this.setSsMimeType(r.getSsMimeType());
		this.setSsMediaFileTypeId(r.getSsMediaFileTypeId());
		this.setSsFileBinary(r.getSsFileBinary());
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
		if ((obj == null) || !(obj instanceof ENt_MTMediaEntityRecord)) {
			return false;
		}
		ENt_MTMediaEntityRecord b = (ENt_MTMediaEntityRecord) obj;
		if (this.getSsMediaId() != b.getSsMediaId()) return false;
		if (!this.getSsFileName().equals(b.getSsFileName())) return false;
		if (!this.getSsMimeType().equals(b.getSsMimeType())) return false;
		if (this.getSsMediaFileTypeId() != b.getSsMediaFileTypeId()) return false;
		if (!RuntimePlatformUtils.compareByteArrays(this.getSsFileBinary(), b.getSsFileBinary())) return false;
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
			return super.hashCode() ^ getSsFileName().hashCode() ^ getSsMimeType().hashCode() ^ System.identityHashCode(getSsFileBinary()) ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_MTMediaEntityRecord duplicate() throws Exception {
		ENt_MTMediaEntityRecord t = new ENt_MTMediaEntityRecord();
		t._ssMediaId = this._ssMediaId;
		t._ssFileName = this._ssFileName;
		t._ssMimeType = this._ssMimeType;
		t._ssMediaFileTypeId = this._ssMediaFileTypeId;
		if (this._ssFileBinary != null) {
			t._ssFileBinary = (byte[]) this._ssFileBinary.clone();
		} else {
			t._ssFileBinary = null;
		}
		t._ssInsertDate = this._ssInsertDate;
		t._ssUpdateDate = this._ssUpdateDate;
		t.ChangedAttributes = new BitSet(7);
		t.OptimizedAttributes = new BitSet(7);
		for (int i = 0; i < 7; i++) {
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".MediaId")) VarValue.appendAttribute(recordElem, "MediaId", Long.valueOf(getSsMediaId()), detailLevel, TypeKind.LongInteger); else VarValue.appendOptimizedAttribute(recordElem, "MediaId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".FileName")) VarValue.appendAttribute(recordElem, "FileName", getSsFileName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "FileName");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".MimeType")) VarValue.appendAttribute(recordElem, "MimeType", getSsMimeType(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "MimeType");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".MediaFileTypeId")) VarValue.appendAttribute(recordElem, "MediaFileTypeId", Integer.valueOf(getSsMediaFileTypeId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "MediaFileTypeId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".FileBinary")) VarValue.appendAttribute(recordElem, "FileBinary", getSsFileBinary(), detailLevel, TypeKind.BinaryData); else VarValue.appendOptimizedAttribute(recordElem, "FileBinary");
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
		} else if (head.equals("filename")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".FileName")) variable.setValue(getSsFileName()); else variable.setOptimized(true);
		} else if (head.equals("mimetype")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".MimeType")) variable.setValue(getSsMimeType()); else variable.setOptimized(true);
		} else if (head.equals("mediafiletypeid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".MediaFileTypeId")) variable.setValue(getSsMediaFileTypeId()); else variable.setOptimized(true);
		} else if (head.equals("filebinary")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".FileBinary")) variable.setValue(getSsFileBinary()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MTMediaEntityRecord t = (ENt_MTMediaEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdFileName)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdMimeType)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdMediaFileTypeId)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdFileBinary)) {
			return ChangedAttributes.get(4);
		} else if (key.equals(IdInsertDate)) {
			return ChangedAttributes.get(5);
		} else if (key.equals(IdUpdateDate)) {
			return ChangedAttributes.get(6);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdFileName)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdMimeType)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdMediaFileTypeId)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdFileBinary)) {
			return OptimizedAttributes.get(4);
		} else if (key.equals(IdInsertDate)) {
			return OptimizedAttributes.get(5);
		} else if (key.equals(IdUpdateDate)) {
			return OptimizedAttributes.get(6);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdMediaId)) {
			return getSsMediaId();
		} else if (key.equals(IdFileName)) {
			return getSsFileName();
		} else if (key.equals(IdMimeType)) {
			return getSsMimeType();
		} else if (key.equals(IdMediaFileTypeId)) {
			return getSsMediaFileTypeId();
		} else if (key.equals(IdFileBinary)) {
			return getSsFileBinary();
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
		ChangedAttributes = new BitSet(7);
		OptimizedAttributes = new BitSet(7);
		setSsMediaId(((Long) other.attributeGet(IdMediaId)).longValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdMediaId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdMediaId));
		setSsFileName((String) other.attributeGet(IdFileName));
		ChangedAttributes.set(1, other.changedAttributeGet(IdFileName));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdFileName));
		setSsMimeType((String) other.attributeGet(IdMimeType));
		ChangedAttributes.set(2, other.changedAttributeGet(IdMimeType));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdMimeType));
		setSsMediaFileTypeId(((Integer) other.attributeGet(IdMediaFileTypeId)).intValue());
		ChangedAttributes.set(3, other.changedAttributeGet(IdMediaFileTypeId));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdMediaFileTypeId));
		setSsFileBinary((byte[]) other.attributeGet(IdFileBinary));
		ChangedAttributes.set(4, other.changedAttributeGet(IdFileBinary));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdFileBinary));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(5, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(6, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(6, other.optimizedAttributeGet(IdUpdateDate));
	}
}
