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


@outsystems.hubedition.runtimeplatform.metainformation.EntityRecordDetails(name = "t_MUArtistSocialMedia", key = "IsbBJL2dfEWccGYyGf2dKA", ownerKey = "oJe9tylD_EGUBlO4A46FUA", generation = 0, physicalTableName = "[dbo].[t_MUArtistSocialMedia]", dbConnection = "")
public final class ENt_MUArtistSocialMediaEntityRecord implements Serializable, Cloneable, ITypedRecord<ENt_MUArtistSocialMediaEntityRecord>, ISimpleRecord {

	private static final GlobalObjectKey IdArtistId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*D0qF9tyQ7kOYwRLQBdD4LA");
	private static final GlobalObjectKey IdSocialMediaId = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*1b2lhK1dmUOuyJRmllD6LA");
	private static final GlobalObjectKey IdLink = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*ewuY9+reKEmqJyCb7t4a_w");
	private static final GlobalObjectKey IdInsertDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*NPjxCoO9DkyqxKMeQobEQQ");
	private static final GlobalObjectKey IdUpdateDate = GlobalObjectKey.parse("oJe9tylD_EGUBlO4A46FUA*gSSMubsnqU+_3yW5yu3Wiw");

	public static void ensureInitialized() {}
	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "ArtistId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssArtistId;
	public int getSsArtistId() {
		return _ssArtistId;
	}
	public void setSsArtistId(int value) {
		if ((_ssArtistId != value) || OptimizedAttributes.get(0)) {
			ChangedAttributes.set(0, true);
			_ssArtistId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "SocialMediaId", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=true, isMandatory=true)
	private int _ssSocialMediaId;
	public int getSsSocialMediaId() {
		return _ssSocialMediaId;
	}
	public void setSsSocialMediaId(int value) {
		if ((_ssSocialMediaId != value) || OptimizedAttributes.get(1)) {
			ChangedAttributes.set(1, true);
			_ssSocialMediaId = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "Link", length=5000, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
	private String _ssLink;
	public String getSsLink() {
		return _ssLink;
	}
	public void setSsLink(String value) {
		if ((!_ssLink.equals(value)) || OptimizedAttributes.get(2)) {
			ChangedAttributes.set(2, true);
			_ssLink = value;
		}
	}

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "InsertDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
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

	@outsystems.hubedition.runtimeplatform.metainformation.EntityAttributeDetails(name= "UpdateDate", length=0, isAutonumber=false, isPrimaryKey=false, isEntityReference=false, isMandatory=false)
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
	public ENt_MUArtistSocialMediaEntityRecord() {
		ChangedAttributes = BitSetUtils.newInstance(5, true);
		OptimizedAttributes = BitSetUtils.newInstance(5, false);
		_ssArtistId = 0;
		_ssSocialMediaId = 0;
		_ssLink = "";
		_ssInsertDate = new DateTime(1900, 1, 1, 0, 0, 0);
		_ssUpdateDate = new DateTime(1900, 1, 1, 0, 0, 0);
	}

	/**
	 *
	 * Get Record instance
	 *
	 * @return  The record type
	 */
	public RCt_MUArtistSocialMediaRecord toRecord() {
		try {
			return new RCt_MUArtistSocialMediaRecord(this);
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
		setSsArtistId(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistSocialMedia.ArtistId", 0));
		setSsSocialMediaId(DataReaderUtils.readEntityReference(r, index++, "t_MUArtistSocialMedia.SocialMediaId", 0));
		setSsLink(DataReaderUtils.readText(r, index++, "t_MUArtistSocialMedia.Link", ""));
		setSsInsertDate(DataReaderUtils.readDateTime(r, index++, "t_MUArtistSocialMedia.InsertDate", new DateTime(1900, 1, 1, 0, 0, 0)));
		setSsUpdateDate(DataReaderUtils.readDateTime(r, index++, "t_MUArtistSocialMedia.UpdateDate", new DateTime(1900, 1, 1, 0, 0, 0)));
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
	public void readIM(ENt_MUArtistSocialMediaEntityRecord r) throws Exception {
		this.setSsArtistId(r.getSsArtistId());
		this.setSsSocialMediaId(r.getSsSocialMediaId());
		this.setSsLink(r.getSsLink());
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
		if ((obj == null) || !(obj instanceof ENt_MUArtistSocialMediaEntityRecord)) {
			return false;
		}
		ENt_MUArtistSocialMediaEntityRecord b = (ENt_MUArtistSocialMediaEntityRecord) obj;
		if (this.getSsArtistId() != b.getSsArtistId()) return false;
		if (this.getSsSocialMediaId() != b.getSsSocialMediaId()) return false;
		if (!this.getSsLink().equals(b.getSsLink())) return false;
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
			return super.hashCode() ^ getSsLink().hashCode() ^ getSsInsertDate().hashCode() ^ getSsUpdateDate().hashCode();
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
	public ENt_MUArtistSocialMediaEntityRecord duplicate() throws Exception {
		ENt_MUArtistSocialMediaEntityRecord t = new ENt_MUArtistSocialMediaEntityRecord();
		t._ssArtistId = this._ssArtistId;
		t._ssSocialMediaId = this._ssSocialMediaId;
		t._ssLink = this._ssLink;
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
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".ArtistId")) VarValue.appendAttribute(recordElem, "ArtistId", Integer.valueOf(getSsArtistId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "ArtistId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".SocialMediaId")) VarValue.appendAttribute(recordElem, "SocialMediaId", Integer.valueOf(getSsSocialMediaId()), detailLevel, TypeKind.EntityReference); else VarValue.appendOptimizedAttribute(recordElem, "SocialMediaId");
			if (!VarValue.fieldIsOptimized(parent, fieldName + ".Link")) VarValue.appendAttribute(recordElem, "Link", getSsLink(), detailLevel, TypeKind.Text); else VarValue.appendOptimizedAttribute(recordElem, "Link");
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
		if (head.equals("artistid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".ArtistId")) variable.setValue(getSsArtistId()); else variable.setOptimized(true);
		} else if (head.equals("socialmediaid")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".SocialMediaId")) variable.setValue(getSsSocialMediaId()); else variable.setOptimized(true);
		} else if (head.equals("link")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".Link")) variable.setValue(getSsLink()); else variable.setOptimized(true);
		} else if (head.equals("insertdate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".InsertDate")) variable.setValue(getSsInsertDate()); else variable.setOptimized(true);
		} else if (head.equals("updatedate")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".UpdateDate")) variable.setValue(getSsUpdateDate()); else variable.setOptimized(true);
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		ENt_MUArtistSocialMediaEntityRecord t = (ENt_MUArtistSocialMediaEntityRecord) super.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(IdArtistId)) {
			return ChangedAttributes.get(0);
		} else if (key.equals(IdSocialMediaId)) {
			return ChangedAttributes.get(1);
		} else if (key.equals(IdLink)) {
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
		if (key.equals(IdArtistId)) {
			return OptimizedAttributes.get(0);
		} else if (key.equals(IdSocialMediaId)) {
			return OptimizedAttributes.get(1);
		} else if (key.equals(IdLink)) {
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
		if (key.equals(IdArtistId)) {
			return getSsArtistId();
		} else if (key.equals(IdSocialMediaId)) {
			return getSsSocialMediaId();
		} else if (key.equals(IdLink)) {
			return getSsLink();
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
		setSsArtistId(((Integer) other.attributeGet(IdArtistId)).intValue());
		ChangedAttributes.set(0, other.changedAttributeGet(IdArtistId));
		OptimizedAttributes.set(0, other.optimizedAttributeGet(IdArtistId));
		setSsSocialMediaId(((Integer) other.attributeGet(IdSocialMediaId)).intValue());
		ChangedAttributes.set(1, other.changedAttributeGet(IdSocialMediaId));
		OptimizedAttributes.set(1, other.optimizedAttributeGet(IdSocialMediaId));
		setSsLink((String) other.attributeGet(IdLink));
		ChangedAttributes.set(2, other.changedAttributeGet(IdLink));
		OptimizedAttributes.set(2, other.optimizedAttributeGet(IdLink));
		setSsInsertDate((DateTime) other.attributeGet(IdInsertDate));
		ChangedAttributes.set(3, other.changedAttributeGet(IdInsertDate));
		OptimizedAttributes.set(3, other.optimizedAttributeGet(IdInsertDate));
		setSsUpdateDate((DateTime) other.attributeGet(IdUpdateDate));
		ChangedAttributes.set(4, other.changedAttributeGet(IdUpdateDate));
		OptimizedAttributes.set(4, other.optimizedAttributeGet(IdUpdateDate));
	}
}
