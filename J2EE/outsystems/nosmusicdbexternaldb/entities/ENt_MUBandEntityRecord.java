package outsystems.nosmusicdbexternaldb.entities;

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
import outsystems.nosmusicdbexternaldb.records.*;

import outsystems.nosmusicdbexternaldb.entities.*;
import outsystems.nosmusicdbexternaldb.structures.*;
import outsystems.nosmusicdbexternaldb.recordlists.*;


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUBand", key = "DKN4qyywtE6VWZ8OHTuyxg", ownerKey = "2OOKx3hUlUqqxagv7u8ECw", generation = 0, physicalTableName = "[MusicDB].[dbo].[t_MUBand]", dbConnection = "")
public final class ENt_MUBandEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUBandEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdBandId = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*SiwAD0zRb0Kzc1lvVQQdEg");
	private static final GlobalObjectKey IdName = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*IbGa3RlvtECItenVREmrgA");
	private static final GlobalObjectKey IdDescription = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*+9oRg7Hzu06xHUvVJakI3g");
	private static final GlobalObjectKey IdLogo = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*Y4yHDEhHQ0Cb8vIgJhzShA");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*UqcWNTVOZUmFAORc9773UQ");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("2OOKx3hUlUqqxagv7u8ECw*AcDLqQGUiUqBEQG5aANB2g");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "BandId", length=0, isAutonumber=true, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private int _ssBandId;
	public int getSsBandId() {
		return _ssBandId;
	}
	public void setSsBandId(int value) {
		if ((_ssBandId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes = BitSetUtils.newInstance(6, true);
			_ssBandId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Name", length=500, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private String _ssName;
	public String getSsName() {
		return _ssName;
	}
	public void setSsName(String value) {
		if ((!_ssName.equals(value)) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssName = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Description", length=1073741823, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssDescription;
	public String getSsDescription() {
		return _ssDescription;
	}
	public void setSsDescription(String value) {
		if ((!_ssDescription.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssDescription = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Logo", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private byte[] _ssLogo;
	public byte[] getSsLogo() {
		return _ssLogo;
	}
	public void setSsLogo(byte[] value) {
		if ((_ssLogo != value) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssLogo = value;
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
	public ENt_MUBandEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(6, true);
		OptimizedAttributes = BitSetUtils.newInstance(6, false);
		_ssBandId = 0;
		_ssName = "";
		_ssDescription = "";
		_ssLogo = new byte[] {};
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUBandRecord toRecord() {
		try {
			return new RCt_MUBandRecord(this);
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
		setSsBandId(DataReaderUtils.readInteger(r, index++, "t_MUBand.BandId", 0));
		setSsName(DataReaderUtils.readText(r, index++, "t_MUBand.Name", ""));
		setSsDescription(DataReaderUtils.readText(r, index++, "t_MUBand.Description", ""));
		setSsLogo(DataReaderUtils.readBinaryData(r, index++, "t_MUBand.Logo", new byte[] {}));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUBand.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUBand.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
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
	public void readIM(ENt_MUBandEntityRecord r) throws Exception {
		this.setSsBandId(r.getSsBandId());
		this.setSsName(r.getSsName());
		this.setSsDescription(r.getSsDescription());
		this.setSsLogo(r.getSsLogo());
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
		if ((obj == null) || !(obj instanceof ENt_MUBandEntityRecord)) {
			return false;
		}
		ENt_MUBandEntityRecord b = (ENt_MUBandEntityRecord) obj;
		if (this.getSsBandId() != b.getSsBandId()) return false;
		if (!this.getSsName().equals(b.getSsName())) return false;
		if (!this.getSsDescription().equals(b.getSsDescription())) return false;
		if (!RuntimePlatformUtils.compareByteArrays(this.getSsLogo(), b.getSsLogo())) return false;
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
			return super.hashCode() ^ getSsName().hashCode() ^ getSsDescription().hashCode() ^ System.identityHashCode(getSsLogo()) ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_MUBandEntityRecord duplicate() throws Exception {
		ENt_MUBandEntityRecord t = new ENt_MUBandEntityRecord();
		t._ssBandId = this._ssBandId;
		t._ssName = this._ssName;
		t._ssDescription = this._ssDescription;
		if (this._ssLogo != null) {
			t._ssLogo = (byte[]) this._ssLogo.clone();
		} else {
			t._ssLogo = null;
		}
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".BandId")) VarValue.appendAttribute(recordElem, "BandId", Integer.valueOf(getSsBandId()), detailLevel, TypeKind.Integer); else VarValue.appendOptimizedAttribute(recordElem, "BandId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Name")) VarValue.appendAttribute(recordElem, "Name", getSsName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Name");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Description")) VarValue.appendAttribute(recordElem, "Description", getSsDescription(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Description");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Logo")) VarValue.appendAttribute(recordElem, "Logo", getSsLogo(), detailLevel, TypeKind.BinaryData); else VarValue.appendOptimizedAttribute(recordElem, "Logo");
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
		if (head.equals("bandid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".BandId")) variable.setValue(getSsBandId()); else variable.setOptimized(true);
		} else if (head.equals("name")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Name")) variable.setValue(getSsName()); else variable.setOptimized(true);
		} else if (head.equals("description")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Description")) variable.setValue(getSsDescription()); else variable.setOptimized(true);
		} else if (head.equals("logo")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Logo")) variable.setValue(getSsLogo()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUBandEntityRecord t = (ENt_MUBandEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdBandId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdDescription)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdLogo)) {
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
		if (key.equals(IdBandId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdDescription)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdLogo)) {
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
		if (key.equals(IdBandId)) {
			return getSsBandId();
		} else if (key.equals(IdName)) {
			return getSsName();
		} else if (key.equals(IdDescription)) {
			return getSsDescription();
		} else if (key.equals(IdLogo)) {
			return getSsLogo();
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
		setSsBandId(((Integer) other.attributeGet(IdBandId)).intValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdBandId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdBandId));
		setSsName((String) other.attributeGet(IdName));
		ChangedAttributes.set(1, other.changedAttributeGet(IdName));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdName));
		setSsDescription((String) other.attributeGet(IdDescription));
		ChangedAttributes.set(2, other.changedAttributeGet(IdDescription));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdDescription));
		setSsLogo((byte[]) other.attributeGet(IdLogo));
		ChangedAttributes.set(3, other.changedAttributeGet(IdLogo));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdLogo));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(4, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(5, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(5, other.optimizedAttributeGet(IdUpdateDate));
	}
}
