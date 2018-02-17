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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MDCountry", key = "VSq91iDBIUG6dTJy1LceLg", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MDCountry]", dbConnection = "")
public final class ENt_MDCountryEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MDCountryEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdIso = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*mXwSWPvOl02b0XZzHpk8Eg");
	private static final GlobalObjectKey IdName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*0iY0JoQPfkOe5JDHZfo9Kg");
	private static final GlobalObjectKey IdPrintableName = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*yiCVlmqL20K0JV5EFSR3Eg");
	private static final GlobalObjectKey IdIso3 = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*NyFG7y8FrE+FsGPneviOvA");
	private static final GlobalObjectKey IdCountryId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*eEFLOLEfy0++l0nf5V9UTA");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Iso", length=2, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private String _ssIso;
	public String getSsIso() {
		return _ssIso;
	}
	public void setSsIso(String value) {
		if ((!_ssIso.equals(value)) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssIso = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Name", length=80, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
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

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "PrintableName", length=80, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=true)
	private String _ssPrintableName;
	public String getSsPrintableName() {
		return _ssPrintableName;
	}
	public void setSsPrintableName(String value) {
		if ((!_ssPrintableName.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssPrintableName = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Iso3", length=3, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssIso3;
	public String getSsIso3() {
		return _ssIso3;
	}
	public void setSsIso3(String value) {
		if ((!_ssIso3.equals(value)) || OptimizedAttributes.get(3)) {
			ChangedAttributes.set(3, true);
			_ssIso3 = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "CountryId", length=0, isAutonumber=false, isPrimaryKey=true, isEntityReference=false, isMandatory=true)
	private int _ssCountryId;
	public int getSsCountryId() {
		return _ssCountryId;
	}
	public void setSsCountryId(int value) {
		if ((_ssCountryId != value) || OptimizedAttributes.get(4)) {
			ChangedAttributes = BitSetUtils.newInstance(5, true);
			_ssCountryId = value;
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
	public ENt_MDCountryEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(5, true);
		OptimizedAttributes = BitSetUtils.newInstance(5, false);
		_ssIso = "";
		_ssName = "";
		_ssPrintableName = "";
		_ssIso3 = "";
		_ssCountryId = 0;
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MDCountryRecord toRecord() {
		try {
			return new RCt_MDCountryRecord(this);
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
		setSsIso(DataReaderUtils.readText(r, index++, "t_MDCountry.Iso", ""));
		setSsName(DataReaderUtils.readText(r, index++, "t_MDCountry.Name", ""));
		setSsPrintableName(DataReaderUtils.readText(r, index++, "t_MDCountry.PrintableName", ""));
		setSsIso3(DataReaderUtils.readText(r, index++, "t_MDCountry.Iso3", ""));
		setSsCountryId(DataReaderUtils.readInteger(r, index++, "t_MDCountry.CountryId", 0));
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
	public void readIM(ENt_MDCountryEntityRecord r) throws Exception {
		this.setSsIso(r.getSsIso());
		this.setSsName(r.getSsName());
		this.setSsPrintableName(r.getSsPrintableName());
		this.setSsIso3(r.getSsIso3());
		this.setSsCountryId(r.getSsCountryId());
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
		if ((obj == null) || !(obj instanceof ENt_MDCountryEntityRecord)) {
			return false;
		}
		ENt_MDCountryEntityRecord b = (ENt_MDCountryEntityRecord) obj;
		if (!this.getSsIso().equals(b.getSsIso())) return false;
		if (!this.getSsName().equals(b.getSsName())) return false;
		if (!this.getSsPrintableName().equals(b.getSsPrintableName())) return false;
		if (!this.getSsIso3().equals(b.getSsIso3())) return false;
		if (this.getSsCountryId() != b.getSsCountryId()) return false;
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
			return super.hashCode() ^ getSsIso().hashCode() ^ getSsName().hashCode() ^ getSsPrintableName().hashCode() ^ getSsIso3().hashCode();
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
	public ENt_MDCountryEntityRecord duplicate() throws Exception {
		ENt_MDCountryEntityRecord t = new ENt_MDCountryEntityRecord();
		t._ssIso = this._ssIso;
		t._ssName = this._ssName;
		t._ssPrintableName = this._ssPrintableName;
		t._ssIso3 = this._ssIso3;
		t._ssCountryId = this._ssCountryId;
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Iso")) VarValue.appendAttribute(recordElem, "Iso", getSsIso(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Iso");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Name")) VarValue.appendAttribute(recordElem, "Name", getSsName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Name");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".PrintableName")) VarValue.appendAttribute(recordElem, "PrintableName", getSsPrintableName(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "PrintableName");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Iso3")) VarValue.appendAttribute(recordElem, "Iso3", getSsIso3(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Iso3");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".CountryId")) VarValue.appendAttribute(recordElem, "CountryId", Integer.valueOf(getSsCountryId()), detailLevel, TypeKind.Integer); else VarValue.appendOptimizedAttribute(recordElem, "CountryId");
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("iso")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Iso")) variable.setValue(getSsIso()); else variable.setOptimized(true);
		} else if (head.equals("name")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Name")) variable.setValue(getSsName()); else variable.setOptimized(true);
		} else if (head.equals("printablename")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".PrintableName")) variable.setValue(getSsPrintableName()); else variable.setOptimized(true);
		} else if (head.equals("iso3")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Iso3")) variable.setValue(getSsIso3()); else variable.setOptimized(true);
		} else if (head.equals("countryid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".CountryId")) variable.setValue(getSsCountryId()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MDCountryEntityRecord t = (ENt_MDCountryEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdIso)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdPrintableName)) {
			return ChangedAttributes.get(2);
		} else if (key.equals(IdIso3)) {
			return ChangedAttributes.get(3);
		} else if (key.equals(IdCountryId)) {
			return ChangedAttributes.get(4);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdIso)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdName)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdPrintableName)) {
			return OptimizedAttributes.get(2);
		} else if (key.equals(IdIso3)) {
			return OptimizedAttributes.get(3);
		} else if (key.equals(IdCountryId)) {
			return OptimizedAttributes.get(4);
		} else {
			throw new Exception("Invalid key");
		}
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdIso)) {
			return getSsIso();
		} else if (key.equals(IdName)) {
			return getSsName();
		} else if (key.equals(IdPrintableName)) {
			return getSsPrintableName();
		} else if (key.equals(IdIso3)) {
			return getSsIso3();
		} else if (key.equals(IdCountryId)) {
			return getSsCountryId();
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ChangedAttributes = new BitSet(5);
		OptimizedAttributes = new BitSet(5);
		setSsIso((String) other.attributeGet(IdIso));
		ChangedAttributes.set(0, other.changedAttributeGet(IdIso));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdIso));
		setSsName((String) other.attributeGet(IdName));
		ChangedAttributes.set(1, other.changedAttributeGet(IdName));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdName));
		setSsPrintableName((String) other.attributeGet(IdPrintableName));
		ChangedAttributes.set(2, other.changedAttributeGet(IdPrintableName));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdPrintableName));
		setSsIso3((String) other.attributeGet(IdIso3));
		ChangedAttributes.set(3, other.changedAttributeGet(IdIso3));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdIso3));
		setSsCountryId(((Integer) other.attributeGet(IdCountryId)).intValue());
		ChangedAttributes.set(4, other.changedAttributeGet(IdCountryId));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdCountryId));
	}
}
